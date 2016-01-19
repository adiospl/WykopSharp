using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharp.Model;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeTagRepository : ITagRepository
    {
        public Task<BooleanResponse> Block(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<Tag> Entries(string tagName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<Tag> Index(string tagName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<Tag> Links(string tagName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanResponse> Observe(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanResponse> Unblock(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanResponse> Unobserve(string tagName)
        {
            throw new NotImplementedException();
        }
    }
}
