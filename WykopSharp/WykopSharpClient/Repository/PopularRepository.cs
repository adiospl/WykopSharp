using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Enumerable.Links;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_4")]
    public class PopularRepository : AbstractRepository
    {
        public PopularRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<Link>> Promoted(int page, Sort sort)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (!Enum.IsDefined(typeof (Sort), sort)) throw new ArgumentOutOfRangeException(nameof(sort));

            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.PopularPromoted, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Link>> Upcomming(int page, Sort sort)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (!Enum.IsDefined(typeof (Sort), sort)) throw new ArgumentOutOfRangeException(nameof(sort));

            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.PopularUpcomming, HttpMethod.Get, parameters)
                );
        }
    }
}