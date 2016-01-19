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
    public class FakeRankRepository : IRankRepository
    {
        public Task<List<Profile>> Index(RankOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
