using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeFavoritiesRepository : IFavoritiesRepository
    {
        public Task<List<Comment>> Comments()
        {
            throw new NotImplementedException();
        }

        public Task<List<Entry>> Entries()
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Index(int listId)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> Lists()
        {
            throw new NotImplementedException();
        }
    }
}
