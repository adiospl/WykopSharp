using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Builder;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_6")]
    public class SearchRepository : AbstractRepository
    {
        public SearchRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<List<Link>> Index(string query, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Argument is null or whitespace", nameof(query));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var postParametrs = new SortedSet<PostParameter>
            {
                new StringPostParameter("q", query)
            };

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.SearchIndex, HttpMethod.Post, parameters, postParametrs)
                );
        }

        public Task<List<Link>> Links(string query, SearchQuery searchQuery, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Argument is null or whitespace", nameof(query));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.SearchLinks, HttpMethod.Post, parameters, searchQuery.GetQuery())
                );
        }

        public Task<List<Profile>> Profiles(string query, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Argument is null or whitespace", nameof(query));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var postParametrs = new SortedSet<PostParameter>
            {
                new StringPostParameter("q", query)
            };

            return Client.CallApiMethodWithAuth<List<Profile>>(
                new ApiMethod(ApiV1Constants.SearchProfiles, HttpMethod.Post, parameters, postParametrs)
                );
        }

        public Task<List<Entry>> Entries(string query, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Argument is null or whitespace", nameof(query));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var postParametrs = new SortedSet<PostParameter>
            {
                new StringPostParameter("q", query)
            };

            return Client.CallApiMethodWithAuth<List<Entry>>(
                new ApiMethod(ApiV1Constants.SearchEntries, HttpMethod.Post, parameters, postParametrs)
                );
        }
    }
}