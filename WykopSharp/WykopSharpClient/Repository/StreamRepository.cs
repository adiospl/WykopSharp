using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Enumerable;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_16")]
    public class StreamRepository : AbstractRepository, IStreamRepository
    {
        public StreamRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<Entry>> Index(int page = 1)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            return Client.CallApiMethodWithAuth<List<Entry>>(
                new ApiMethod(ApiV1Constants.StreamIndex, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Entry>> Hot(Period period, int page = 1)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (!Enum.IsDefined(typeof (Period), period)) throw new ArgumentOutOfRangeException(nameof(period));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));
            parameters.Add(new ApiParameter("period", (int)period));

            return Client.CallApiMethodWithAuth<List<Entry>>(
                new ApiMethod(ApiV1Constants.StreamHot, HttpMethod.Get, parameters)
                );
        }
    }
}