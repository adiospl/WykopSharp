using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeUserRepository : IUserRepository
    {
        public HashSet<ApiParameter> GetApiParameterSet()
        {
            throw new NotImplementedException();
        }

        public Task<Login> Login(string accountKey)
        {
            throw new NotImplementedException();
        }

        public Task<Login> Login(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Uri Connect()
        {
            throw new NotImplementedException();
        }

        public Uri Connect(Uri redirectUrl, string appSecret)
        {
            throw new NotImplementedException();
        }
    }
}
