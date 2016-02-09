using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharp.Model;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeConversationRepository : IConversationRepository
    {
        public Task<BooleanModel> Delete(string username)
        {
            throw new NotImplementedException();
        }

        public Task<List<ConversationList>> List()
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Send(string username, string body, ByteFile file)
        {
            throw new NotImplementedException();
        }

        public Task<BooleanModel> Send(string username, string body, string embed = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<PmMessage>> Show(string username)
        {
            throw new NotImplementedException();
        }
    }
}
