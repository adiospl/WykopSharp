using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Enumerable.Links;
using WykopSharpClient.Enumerable.Search;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_3")]
    public class LinksRepository : AbstractRepository
    {
        public LinksRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<Link>> Promoted(int page, PromotedSort sort)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (!Enum.IsDefined(typeof (Sort), sort)) throw new ArgumentOutOfRangeException(nameof(sort));

            var parameters = new HashSet<ApiParameter>
            {
                new ApiParameter("page", page),
                new ApiParameter("sort", sort.ToString().ToLower())
            };
            if (Client.UserKey != null) parameters.Add(new ApiParameter("userkey", Client.UserKey));

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.LinksPromoted, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Link>> Upcomming(int page, UpcommingSort sort)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (!Enum.IsDefined(typeof (Sort), sort)) throw new ArgumentOutOfRangeException(nameof(sort));

            var parameters = new HashSet<ApiParameter>
            {
                new ApiParameter("page", page),
                new ApiParameter("sort", sort.ToString().ToLower())
            };
            if (Client.UserKey != null) parameters.Add(new ApiParameter("userkey", Client.UserKey));

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.LinksUpcomming, HttpMethod.Get, parameters)
                );
        }
    }
}