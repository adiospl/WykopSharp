using System;
using System.Collections.Generic;
using System.Net.Http;
using WykopSharp.Exceptions;

namespace WykopSharp
{
    public class ApiMethod
    {
        public ApiMethod(string methodUrl,
            HttpMethod httpMethod,
            HashSet<ApiParameter> apiParameters
            )
            : this(
                methodUrl, httpMethod, apiParameters, new SortedSet<StringMethodParameter>(),
                new SortedSet<PostParameter>())
        {
        }

        public ApiMethod(string methodUrl,
            HttpMethod httpMethod,
            HashSet<ApiParameter> apiParameters,
            SortedSet<StringMethodParameter> methodParameters
            )
            : this(methodUrl, httpMethod, apiParameters, methodParameters, new SortedSet<PostParameter>())
        {
        }

        public ApiMethod(string methodUrl,
            HttpMethod httpMethod,
            HashSet<ApiParameter> apiParameters,
            SortedSet<PostParameter> postParameters
            )
            : this(methodUrl, httpMethod, apiParameters, new SortedSet<StringMethodParameter>(), postParameters)
        {
        }

        public ApiMethod(
            string methodUrl,
            HttpMethod httpMethod,
            HashSet<ApiParameter> apiParameters,
            SortedSet<StringMethodParameter> methodParameters,
            SortedSet<PostParameter> postParameters
            )
        {
            if (methodUrl == null)
                throw new ArgumentNullException(nameof(methodUrl));
            if (methodUrl.Length == 0)
                throw new ArgumentException("Method URL cannot be empty.", nameof(methodUrl));
            if (httpMethod != HttpMethod.Get && httpMethod != HttpMethod.Post)
                throw new UnsupportedHttpMethodException("The http method must be either GET or POST.");

            Url = methodUrl;
            HttpMethod = httpMethod;
            ApiParameters = apiParameters;
            MethodParameters = methodParameters;
            PostParameters = postParameters;
        }

        public string Url { get; }
        public HttpMethod HttpMethod { get; }
        public HashSet<ApiParameter> ApiParameters { get; }
        public SortedSet<StringMethodParameter> MethodParameters { get; }
        public SortedSet<PostParameter> PostParameters { get; }
    }
}