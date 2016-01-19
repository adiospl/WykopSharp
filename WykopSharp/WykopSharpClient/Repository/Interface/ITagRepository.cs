using System.Threading.Tasks;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface ITagRepository
    {
        Task<BooleanResponse> Block(string tagName);
        Task<Tag> Entries(string tagName, int page = 1);
        Task<Tag> Index(string tagName, int page = 1);
        Task<Tag> Links(string tagName, int page = 1);
        Task<BooleanResponse> Observe(string tagName);
        Task<BooleanResponse> Unblock(string tagName);
        Task<BooleanResponse> Unobserve(string tagName);
    }
}