using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharpClient.Enumerable;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeStreamRepository : IStreamRepository
    {
        public Task<List<Entry>> Hot(Period period, int page = 1)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entry>> Index(int page = 1)
        {
            throw new NotImplementedException();
        }
    }
}
