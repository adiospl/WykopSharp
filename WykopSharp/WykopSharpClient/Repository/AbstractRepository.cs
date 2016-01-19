using System;
using System.Collections.Generic;
using WykopSharp;
using WykopSharp.Model;
using WykopSharpClient.Repository.Interface;

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
}