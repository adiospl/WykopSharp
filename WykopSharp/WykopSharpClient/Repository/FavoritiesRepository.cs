using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_15")]
    public class FavoritiesRepository : AbstractRepository
    {
        public FavoritiesRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<Link>> Index(int listId)
        {
            if (listId <= 0) throw new ArgumentOutOfRangeException(nameof(listId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", listId)
            };

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.FavoritesIndex, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Comment>> Comments()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Comment>>(
                new ApiMethod(ApiV1Constants.FavoritesComments, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Entry>> Entries()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<Entry>>(
                new ApiMethod(ApiV1Constants.FavoritesEntries, HttpMethod.Get, parameters)
                );
        }

        public Task<List<object>> Lists()
        {
            var parameters = GetApiParameterSet();

            return Client.CallApiMethodWithAuth<List<object>>(
                new ApiMethod(ApiV1Constants.FavoritesLists, HttpMethod.Get, parameters)
                );
        }
    }
}