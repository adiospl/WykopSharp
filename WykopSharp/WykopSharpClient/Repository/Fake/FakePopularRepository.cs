using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharpClient.Enumerable.Links;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakePopularRepository : IPopularRepository
    {
        public Task<List<Link>> Promoted(int page, PromotedSort promotedSort)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Upcomming(int page, PromotedSort promotedSort)
        {
            throw new NotImplementedException();
        }
    }
}
