using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_14")]
    public class ObservatoryRepository : AbstractRepository
    {
        public ObservatoryRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<object>> Votes()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<object>>(
                new ApiMethod(ApiV1Constants.ObservatoryVotes, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Comment>> Comments()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Comment>>(
                new ApiMethod(ApiV1Constants.ObservatoryComments, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Entry>> Entries()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Entry>>(
                new ApiMethod(ApiV1Constants.ObservatoryEntries, HttpMethod.Get, parameters)
                );
        }

        public Task<List<EntryComment>> EntriesComments()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<EntryComment>>(
                new ApiMethod(ApiV1Constants.ObservatoryEntriesComments, HttpMethod.Get, parameters)
                );
        }
    }
}