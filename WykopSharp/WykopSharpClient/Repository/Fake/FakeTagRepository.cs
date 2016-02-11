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
        public Task<BooleanModel> Block(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entry>> Entries(string tagName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<Tag> Index(string tagName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Links(string tagName, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Observe(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Unblock(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Unobserve(string tagName)
        {
            throw new NotImplementedException();
        }
    }
}
