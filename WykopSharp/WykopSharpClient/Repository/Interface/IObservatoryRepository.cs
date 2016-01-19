using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IObservatoryRepository
    {
        Task<List<Comment>> Comments();
        Task<List<Entry>> Entries();
        Task<List<EntryComment>> EntriesComments();
        Task<List<object>> Votes();
    }
}