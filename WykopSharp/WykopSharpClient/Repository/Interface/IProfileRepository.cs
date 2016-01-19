using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IProfileRepository
    {
        Task<List<Link>> Added(string profileName, int page = 1);
        Task<BooleanResponse> Block(string profileName);
        Task<List<Link>> Buried(string profileName, int page = 1);
        Task<List<Link>> Commented(string profileName, int page = 1);
        Task<List<Comment>> Comments(string profileName, int page = 1);
        Task<List<Link>> Digged(string profileName, int page = 1);
        Task<List<Entry>> Entries(string profileName, int page = 1);
        Task<List<EntryComment>> EntriesComments(string profileName, int page = 1);
        Task<List<Link>> Favorities(string profileName, int listId, int page = 1);
        Task<List<Profile>> Followed(string profileName, int page = 1);
        Task<List<Profile>> Followers(string profileName, int page = 1);
        Task<Profile> Index(string profileName);
        Task<BooleanResponse> Observe(string profileName);
        Task<List<Link>> Published(string profileName, int page = 1);
        Task<List<RelatedLink>> Related(string profileName, int page = 1);
        Task<BooleanResponse> Unblock(string profileName);
        Task<BooleanResponse> Unobserve(string profileName);
    }
}