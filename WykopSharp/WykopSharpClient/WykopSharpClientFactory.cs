using System;
using WykopSharp;
using WykopSharp.Interface;
using WykopSharpClient.Exception;
using WykopSharpClient.Fake;

namespace WykopSharpClient
{
    public static class WykopSharpClientFactory
    {
        public static IWykopSharpClient Create<TApiRequestClient>(string appKey, string appSecret, string userKey)
        {
            if (typeof(TApiRequestClient) == typeof(WykopSharpClient))
            {
                return new WykopSharpClient(appKey, appSecret, userKey);
            }
            if (typeof (TApiRequestClient) == typeof (WykopSharpFakeClient))
            {
                return new WykopSharpClient(String.Empty, String.Empty, String.Empty);
            }

            throw new ApiClientIsNotSupportedException("Client with type {typeof (TClient).FullName} is not supported");
        }
    }
}