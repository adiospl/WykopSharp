using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IConversationRepository
    {
        Task<BooleanModel> Delete(string username);
        Task<List<ConversationList>> List();
        Task<BooleanModel> Send(string username, string body, ByteFile file);
        Task<BooleanModel> Send(string username, string body, string embed = null);
        Task<List<PmMessage>> Show(string username);
    }
}