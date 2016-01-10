using WykopSharp;
using WykopSharpClient.Exception;

namespace WykopSharpClient
{
    public class WykopSharpClientFactory : IWykopClientFactory
    {
        public TClient Create<TClient>(string appKey, string appSecret, string userKey) where TClient : ApiRequestClient
        {
            if (typeof (TClient) == typeof (ApiRequestClient))
            {
                // log
                return new ApiRequestClient(appKey, appSecret, userKey) as TClient;
            }
            if (typeof (TClient) == typeof (WykopSharpClient))
            {
                // log
                return new WykopSharpClient(appKey, appSecret, userKey) as TClient;
            }

            throw new ApiClientIsNotSupportedException("Client with type {typeof (TClient).FullName} is not supported");
        }
    }
}