using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Enumerable.Links;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_4")]
    public class PopularRepository : AbstractRepository, IPopularRepository
    {
        public PopularRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<Link>> Promoted(int page)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.PopularPromoted, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Link>> Promoted(int page, PromotedSort promotedSort)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (!Enum.IsDefined(typeof (PromotedSort), promotedSort)) throw new ArgumentOutOfRangeException(nameof(promotedSort));

            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.PopularPromoted, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Link>> Upcomming(int page)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.PopularUpcomming, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Link>> Upcomming(int page, PromotedSort promotedSort)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (!Enum.IsDefined(typeof (PromotedSort), promotedSort)) throw new ArgumentOutOfRangeException(nameof(promotedSort));

            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.PopularUpcomming, HttpMethod.Get, parameters)
                );
        }
    }
}