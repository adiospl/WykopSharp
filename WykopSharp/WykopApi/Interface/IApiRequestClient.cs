using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WykopSharp.Interface
{
    public interface IApiRequestClient : IDisposable
    {
        Task<TResult> CallApiMethod<TResult>(ApiMethod method, IEnumerable<JsonConverter> converters = null) where TResult : class;
        Task<TResult> CallApiMethod<TResponse, TResult>(ApiMethod method, Func<TResponse, TResult> callback, IEnumerable<JsonConverter> converters = null)
            where TResponse : class
            where TResult : class;
        Uri GetApiMethodUrl(ApiMethod method);
    }
}