namespace WykopSharp
{
    public interface IWykopClientFactory
    {
        TClient Create<TClient>(string appKey, string appSecret, string userKey) where TClient : ApiRequestClient;
    }
}