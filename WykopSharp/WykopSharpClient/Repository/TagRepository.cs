using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharp.Model;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_17")]
    public class TagRepository : AbstractRepository, ITagRepository
    {
        public TagRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<Tag> Index(string tagName, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(tagName))
                throw new ArgumentException("Argument is null or whitespace", nameof(tagName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", tagName.Replace("#", ""))
            };

            return Client.CallApiMethodWithAuth<Tag>(
                new ApiMethod(ApiV1Constants.TagIndex, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<Tag> Links(string tagName, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(tagName))
                throw new ArgumentException("Argument is null or whitespace", nameof(tagName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", tagName.Replace("#", ""))
            };

            return Client.CallApiMethodWithAuth<Tag>(
                new ApiMethod(ApiV1Constants.TagLinks, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<Tag> Entries(string tagName, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(tagName))
                throw new ArgumentException("Argument is null or whitespace", nameof(tagName));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("page", page));

            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", tagName.Replace("#", ""))
            };

            return Client.CallApiMethodWithAuth<Tag>(
                new ApiMethod(ApiV1Constants.TagEntries, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanModel> Observe(string tagName)
        {
            if (string.IsNullOrWhiteSpace(tagName))
                throw new ArgumentException("Argument is null or whitespace", nameof(tagName));
            
            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", tagName.Replace("#", ""))
            };

            return Client.CallApiMethodWithAuth<BooleanModel>(
                new ApiMethod(ApiV1Constants.TagObserve, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanModel> Unobserve(string tagName)
        {
            if (string.IsNullOrWhiteSpace(tagName))
                throw new ArgumentException("Argument is null or whitespace", nameof(tagName));
            
            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", tagName.Replace("#", ""))
            };

            return Client.CallApiMethodWithAuth<BooleanModel>(
                new ApiMethod(ApiV1Constants.TagUnobserve, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanModel> Block(string tagName)
        {
            if (string.IsNullOrWhiteSpace(tagName))
                throw new ArgumentException("Argument is null or whitespace", nameof(tagName));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", tagName.Replace("#", ""))
            };

            return Client.CallApiMethodWithAuth<BooleanModel>(
                new ApiMethod(ApiV1Constants.TagBlock, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<BooleanModel> Unblock(string tagName)
        {
            if (string.IsNullOrWhiteSpace(tagName))
                throw new ArgumentException("Argument is null or whitespace", nameof(tagName));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", tagName.Replace("#", ""))
            };

            return Client.CallApiMethodWithAuth<BooleanModel>(
                new ApiMethod(ApiV1Constants.TagUnblock, HttpMethod.Get, parameters, methodParameters)
                );
        }
    }
}