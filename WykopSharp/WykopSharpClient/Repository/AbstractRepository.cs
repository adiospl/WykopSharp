using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    public abstract class AbstractRepository : IRepository
    {
        protected readonly WykopSharpClient Client;

        protected AbstractRepository(WykopSharpClient client)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            Client = client;
        }

        public HashSet<ApiParameter> GetApiParameterSet()
        {
            var parameters = new HashSet<ApiParameter>();
            if (Client.UserKey != null) parameters.Add(new ApiParameter("userkey", Client.UserKey));

            return parameters;
        }
    }

    public interface IRepository
    {
        HashSet<ApiParameter> GetApiParameterSet();
    }
    
    public interface IUserRepository : IRepository
    {
        Task<Login> Login(string accountKey);
        Task<Login> Login(string login, string password);
        Uri Connect();
        Uri Connect(Uri redirectUrl, string appSecret);
    }
}