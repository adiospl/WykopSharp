using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Data.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WykopSharp.Auth;
using WykopSharp.Enumerable;
using WykopSharp.Exceptions;
using WykopSharp.Interface;
using WykopSharp.Model;


namespace WykopSharp
{

    public class ApiRequestClient : IApiRequestClient
    {
        public readonly string AccountKey;

        private readonly string _appKey;
        private readonly string _appSecret;

        private readonly HttpClient _client;

        private readonly object _disposeLock = new object();
        private bool _disposed;

        public ApiRequestClient(string appKey, string appSecret, string accountKey = null)
        {
            if (appKey == null)
                throw new ArgumentNullException(nameof(appKey));
            if (appKey.Length == 0)
                throw new ArgumentException("Cannot be empty", nameof(appKey));
            if (appSecret == null)
                throw new ArgumentNullException(nameof(appSecret));
            if (appSecret.Length == 0)
                throw new ArgumentException("Cannot be empty", nameof(appSecret));

            _appKey = appKey;
            _appSecret = appSecret;
            AccountKey = accountKey;

            _client = new HttpClient();
        }

        public async Task<TResult> CallApiMethod<TResponse, TResult>(ApiMethod method, Func<TResponse, TResult> callback,
            IEnumerable<JsonConverter> converters = null)
            where TResult : class
            where TResponse : class
        {
            if (_disposed)
                throw new ObjectDisposedException("WykopClient");
            if (method == null)
                throw new ArgumentNullException(nameof(method));

            var response = await CallApiMethod<TResponse>(method, converters).ConfigureAwait(false);
            return callback(response);
        }

        private void BuildMethodParameters(StringBuilder apiRequestUrl, ApiMethod method)
        {
            foreach (var parameter in method.MethodParameters)
            {
                apiRequestUrl.Append(parameter.Value);
                apiRequestUrl.Append("/");
            }
        }

        private void BuildApiParameters(StringBuilder apiRequestUrl, ApiMethod method)
        {
            foreach (var parameter in method.ApiParameters)
            {
                if (parameter.CheckIsApiParameterAllowed())
                {
                    apiRequestUrl.Append(parameter.AsUriChunk());
                }
            }
        }

        private MultipartFormDataContent BuilPostContent(ApiMethod method)
        {
            var content = new MultipartFormDataContent();
            foreach (var p in method.PostParameters)
            {
                if (p is StringPostParameter)
                {
                    content.Add(p.AsHttpContent, p.Name);
                }
                else if (p is BytePostParameter)
                {
                    var file = (BytePostParameter) p;
                    content.Add(file.AsHttpContent, file.Name, file.FileName);
                }
            }
            return content;
        }

        public Uri GetApiMethodUrl(ApiMethod method)
        {
            if (method == null) throw new ArgumentNullException(nameof(method));

            var apiRequestUrl = BuildApiRequestUrl(method);
            return new Uri(apiRequestUrl.ToString());
        }

        public async Task<TResult> CallApiMethod<TResult>(ApiMethod method, IEnumerable<JsonConverter> converters = null)
            where TResult : class
        {
            if (_disposed)
                throw new ObjectDisposedException("WykopClient");
            if (method == null)
                throw new ArgumentNullException(nameof(method));

            var apiRequestUrl = BuildApiRequestUrl(method);

            using (var request = new HttpRequestMessage(method.HttpMethod, apiRequestUrl.ToString()))
            {
                AuthSignature signature;
                AddRequestHeader(request);

                if (method.HttpMethod == HttpMethod.Get)
                {
                    signature = new AuthSignature(_appSecret, request.RequestUri);
                }
                else if (method.HttpMethod == HttpMethod.Post)
                {
                    signature = new AuthSignature(_appSecret, request.RequestUri, method.PostParameters);
                    request.Content = BuilPostContent(method);
                }
                else
                {
                    throw new UnsupportedHttpMethodException("Http method {method.HttpMethod} is not supported");
                }

                var hash = signature.FetchSignature();
                request.Headers.Add("apisign", hash);
                
                using (var response = await _client.SendAsync(request, CancellationToken.None).ConfigureAwait(false))
                {
                    if (!response.IsSuccessStatusCode)
                        throw new InvalidResponseException("Response is not success. ", 0);

                    var stringResponse = response.Content.ReadAsStringAsync().Result;
                    var responseType = CheckResponseType(stringResponse, response);
                    ValidateErrors(stringResponse);
                    
                    switch (responseType)
                    {
                        case ResponseType.Html:
                            return (dynamic) new HtmlResponse() { Html = stringResponse };
                        case ResponseType.ValueArray:
                            // API is incosistent - return array with boolean,
                            // but i don't know is that the only one behaviour
                            return (dynamic) new BooleanResponse(stringResponse);
                    }

                    using (var reader = new JsonTextReader(new StringReader(stringResponse)))
                    {
                        var serializer = CreateSerializer(converters);
                        var result = serializer.Deserialize<TResult>(reader);

                        return result;
                    }
                }
            }
        }

        private bool CheckIsValidJSon(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }

        private ResponseType CheckResponseType(string json, HttpResponseMessage response)
        {
            switch (response.Content.Headers.ContentType.MediaType)
            {
                case "text/html":
                    return ResponseType.Html;
                case "application/json":
                    return CheckIsValidJSon(json) ?
                        ResponseType.Json : ResponseType.ValueArray;
            }
            return ResponseType.Unsupported;
        }

        private StringBuilder BuildApiRequestUrl(ApiMethod method)
        {
            var apiRequestUrl = new StringBuilder();
            apiRequestUrl.Append(WykopConstants.AppDomain);
            apiRequestUrl.Append(method.Url);
            apiRequestUrl.Append("/");

            BuildMethodParameters(apiRequestUrl, method);
            BuildApiParameters(apiRequestUrl, method);

            apiRequestUrl.Append("appkey,");
            apiRequestUrl.Append(_appKey);
            return apiRequestUrl;
        }

        protected void AddRequestHeader(HttpRequestMessage request)
        {
            request.Headers.Add("Accept", WykopConstants.Format);
            request.Headers.Add("Accept-Charset", WykopConstants.Charset);
            request.Headers.Add("Cache-Control", WykopConstants.CacheControl);
            request.Headers.Add("User-Agent", WykopConstants.UserAgent);
        }
        
        protected void ValidateErrors(string response)
        {
            using (var reader = new JsonTextReader(new StringReader(response)))
            {
                var serializer = CreateSerializer(null);
                var errorResult = serializer.Deserialize<ErrorResponse>(reader);

                switch (errorResult?.Error?.Code)
                {
                    case null:
                        break;
                    case 1:
                    case 5:
                    case 14:
                    case 17:
                    case 18:
                        throw new ConnectionException(errorResult.Error.Message, errorResult.Error.Code);
                    case 6:
                        throw new SignatureException(errorResult.Error.Message, errorResult.Error.Code);
                    case 999:
                    case 1001:
                    case 1002:
                        throw new ApiException(errorResult.Error.Message, errorResult.Error.Code);
                    case 11:
                    case 12:
                    case 13:
                        throw new AuthorizationException(errorResult.Error.Message, errorResult.Error.Code);
                    case 4:
                    case 7:
                    case 22:
                    case 31:
                    case 33:
                    case 34:
                    case 42:
                        throw new CreditentialsException(errorResult.Error.Message, errorResult.Error.Code);
                    case 21:
                    case 71:
                    case 15:
                        throw new InvalidParametersException(errorResult.Error.Message, errorResult.Error.Code);
                    case 2:
                    case 3:
                    case 32:
                    case 41:
                    case 61:
                    case 81:
                        throw new InvalidResourceException(errorResult.Error.Message, errorResult.Error.Code);
                    default:
                        throw new UnknownApiException("Unknown Api Exception", errorResult?.Error?.Code ?? -1);
                }
            }
        }

        protected virtual JsonSerializer CreateSerializer(IEnumerable<JsonConverter> converters)
        {
            var settings = new JsonSerializerSettings()
            {
                Error = (s, err) => {
                    err.ErrorContext.Handled = true;
                }
            };
            var serializer = JsonSerializer.Create(settings);
            foreach (var converter in converters ?? System.Linq.Enumerable.Empty<JsonConverter>())
                serializer.Converters.Add(converter);

            return serializer;
        }

        #region IDisposable Support

        public void Dispose()
        {
            if (_disposed) return;
            lock (_disposeLock)
            {
                if (_disposed) return;
                _disposed = true;
                _client.Dispose();
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(bool dispose)
        {
        }

        #endregion
    }
}