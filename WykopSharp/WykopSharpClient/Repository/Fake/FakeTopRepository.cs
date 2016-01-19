using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeTopRepository : ITopRepository
    {
        public Task<List<Link>> Date(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> Date(int year, int month)
        {
            throw new NotImplementedException();
        }

        public Task<TopYear> Index(int year)
        {
            throw new NotImplementedException();
        }

        public Task<TopYear> Index(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<List<Link>> RandomHits()
        {
            throw new NotImplementedException();
        }
    }
}
