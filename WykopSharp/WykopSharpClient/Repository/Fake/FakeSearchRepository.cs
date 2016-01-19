using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Builder;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeSearchRepository : ISearchRepository
    {
        public Task<List<Entry>> Entries(string query, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Index(string query, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Links(string query, SearchQuery searchQuery, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Profile>> Profiles(string query, int page = 1)
        {
            throw new NotImplementedException();
        }
    }
}
