using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Builder;

namespace WykopSharpClient.Repository.Interface
{
    public interface ISearchRepository
    {
        Task<List<Entry>> Entries(string query, int page = 1);
        Task<List<Link>> Index(string query, int page = 1);
        Task<List<Link>> Links(string query, SearchQuery searchQuery, int page = 1);
        Task<List<Profile>> Profiles(string query, int page = 1);
    }
}