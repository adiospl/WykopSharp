using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IFavoritiesRepository
    {
        Task<List<Comment>> Comments();
        Task<List<Entry>> Entries();
        Task<List<Link>> Index(int listId);
        Task<List<object>> Lists();
    }
}