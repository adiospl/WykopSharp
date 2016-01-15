using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Enumerable;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_13")]
    public class RankRepository : AbstractRepository
    {
        public RankRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<Profile>> Index(RankOrder order)
        {
            if (!Enum.IsDefined(typeof (RankOrder), order)) throw new ArgumentOutOfRangeException(nameof(order));

            var parameters = GetApiParameterSet();

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", order.ToString().ToLower())
            };

            return Client.CallApiMethodWithAuth<List<Profile>>(
                new ApiMethod(ApiV1Constants.RankIndex, HttpMethod.Get, parameters, methodParameters)
                );
        }
    }
}