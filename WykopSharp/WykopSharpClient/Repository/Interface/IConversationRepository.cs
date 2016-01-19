using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IConversationRepository
    {
        Task<BooleanResponse> Delete(string username);
        Task<List<ConversationList>> List();
        Task<BooleanResponse> Send(string username, string body, ByteFile file);
        Task<BooleanResponse> Send(string username, string body, string embed = null);
        Task<List<PmMessage>> Show(string username);
    }
}