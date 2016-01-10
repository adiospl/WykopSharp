using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_5")]
    public class ProfileRepository : AbstractRepository
    {
        public ProfileRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<Profile> Index(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<Profile>(
                new ApiMethod(ApiV1Constants.ProfileIndex, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Link>> Added(string profileName, int page)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.ProfileAdded, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Link>> Published(string profileName, int page)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.ProfilePublished, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Link>> Commented(string profileName, int page)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.ProfileCommented, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Comment>> Comments(string profileName, int page)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<Comment>>(
                new ApiMethod(ApiV1Constants.ProfileComments, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Link>> Digged(string profileName, int page)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.ProfileDigged, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Link>> Buried(string profileName, int page)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.ProfileBuried, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanResponse> Observe(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<BooleanResponse>(
                new ApiMethod(ApiV1Constants.ProfileObserve, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanResponse> Unobserve(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<BooleanResponse>(
                new ApiMethod(ApiV1Constants.ProfileUnobserve, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanResponse> Block(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<BooleanResponse>(
                new ApiMethod(ApiV1Constants.ProfileBlock, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanResponse> Unblock(string profileName)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<BooleanResponse>(
                new ApiMethod(ApiV1Constants.ProfileUnblock, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Profile>> Followers(string profileName, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<Profile>>(
                new ApiMethod(ApiV1Constants.ProfileFollowers, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Profile>> Followed(string profileName, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<Profile>>(
                new ApiMethod(ApiV1Constants.ProfileFollowed, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Link>> Favorities(string profileName, int listId, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (listId <= 0) throw new ArgumentOutOfRangeException(nameof(listId));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName),
                new StringMethodParameter("param2", listId)
            };

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.ProfileFavorites, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<Entry>> Entries(string profileName, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<Entry>>(
                new ApiMethod(ApiV1Constants.ProfileEntries, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<EntryComment>> EntriesComments(string profileName, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<EntryComment>>(
                new ApiMethod(ApiV1Constants.ProfileEntriesComments, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<List<RelatedLink>> Related(string profileName, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(profileName))
                throw new ArgumentException("Argument is null or whitespace", nameof(profileName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", profileName)
            };

            return Client.CallApiMethodWithAuth<List<RelatedLink>>(
                new ApiMethod(ApiV1Constants.ProfileRelatedLinks, HttpMethod.Get, parameters, methodParameters)
                );
        }
    }
}