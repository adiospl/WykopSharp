using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeTagsRepository : ITagsRepository
    {
        public Task<List<PopularTag>> Popular()
        {
            throw new NotImplementedException();
        }
    }
}
