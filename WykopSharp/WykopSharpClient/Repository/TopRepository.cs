using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository
{
    [Repository]
    public class TopRepository : AbstractRepository, ITopRepository
    {
        public TopRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<TopYear> Index(int year)
        {
            if (year <= 2004) throw new ArgumentOutOfRangeException(nameof(year));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", year)
            };
            
            return Client.CallApiMethodWithAuth<TopYear>(
                new ApiMethod(ApiV1Constants.TopIndex, HttpMethod.Get, parameters, methodParameter)
                );
        }
        
        public Task<TopYear> Index(DateTime date)
        {
            return Index(date.Year);
        }

        public Task<List<Link>> Date(int year, int month)
        {
            if (year <= 2004) throw new ArgumentOutOfRangeException(nameof(year));
            if (month <= 0 && month >=13) throw new ArgumentOutOfRangeException(nameof(month));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", year),
                new StringMethodParameter("param2", month)
            };

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.TopDate, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<List<Link>> Date(DateTime date)
        {
            return Date(date.Year, date.Month);
        }

        public Task<List<Link>> RandomHits()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.TopHits, HttpMethod.Get, parameters)
                );
        } 

    }
}
