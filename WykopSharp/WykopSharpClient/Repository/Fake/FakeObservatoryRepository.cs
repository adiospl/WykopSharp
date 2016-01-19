using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeObservatoryRepository : IObservatoryRepository
    {
        public Task<List<Comment>> Comments()
        {
            throw new NotImplementedException();
        }

        public Task<List<Entry>> Entries()
        {
            throw new NotImplementedException();
        }

        public Task<List<EntryComment>> EntriesComments()
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> Votes()
        {
            throw new NotImplementedException();
        }
    }
}
