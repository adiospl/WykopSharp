using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_2")]
    public class LinkRepository : AbstractRepository
    {
        public LinkRepository(WykopSharpClient client) : base(client)
        {
        }

        [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_9")]
        public Task<List<BuryReason>> BuryReasons()
        {
            var parameters = new HashSet<ApiParameter>();
            
            return Client.CallApiMethodWithAuth<List<BuryReason>>(
                new ApiMethod(ApiV1Constants.LinkIndex, HttpMethod.Get, parameters)
                );
        }

        public Task<List<Link>> Index(int linkId)
        {
            var parameters = GetApiParameterSet();

            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<List<Link>>(
                new ApiMethod(ApiV1Constants.LinkIndex, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<List<DigResponse>> Dig(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<List<DigResponse>>(
                new ApiMethod(ApiV1Constants.LinkDig, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<List<DigResponse>> Cancel(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<List<DigResponse>>(
                new ApiMethod(ApiV1Constants.LinkCancel, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<List<DigResponse>> Bury(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<List<DigResponse>>(
                new ApiMethod(ApiV1Constants.LinkBury, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<List<DigResponse>> Comments(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<List<DigResponse>>(
                new ApiMethod(ApiV1Constants.LinkComments, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<List<Bury>> Reports(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<List<Bury>>(
                new ApiMethod(ApiV1Constants.LinkReports, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<List<Dig>> Digs(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<List<Dig>>(
                new ApiMethod(ApiV1Constants.LinkDig, HttpMethod.Post, parameters, methodParameter)
                );
        }

        public Task<List<RelatedLink>> Related(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<List<RelatedLink>>(
                new ApiMethod(ApiV1Constants.LinkRelated, HttpMethod.Post, parameters, methodParameter)
                );
        }

        public Task<BooleanResponse> Observe(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<BooleanResponse>(
                new ApiMethod(ApiV1Constants.LinkObserve, HttpMethod.Post, parameters, methodParameter)
                );
        }

        public Task<BooleanResponse> Favorite(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<BooleanResponse>(
                new ApiMethod(ApiV1Constants.LinkFavorite, HttpMethod.Post, parameters, methodParameter)
                );
        }


    }
}