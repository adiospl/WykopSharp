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
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_2")]
    public class LinkRepository : AbstractRepository, ILinkRepository
    {
        public LinkRepository(WykopSharpClient client) : base(client)
        {
        }

        [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_9")]
        public Task<List<BuryReason>> BuryReasons()
        {
            var parameters = new HashSet<ApiParameter>();
            
            return Client.CallApiMethodWithAuth<List<BuryReason>>(
                new ApiMethod(ApiV1Constants.LinkBuryreasons, HttpMethod.Get, parameters)
                );
        }

        public Task<Link> Index(int linkId)
        {
            var parameters = GetApiParameterSet();

            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<Link>(
                new ApiMethod(ApiV1Constants.LinkIndex, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<DigModel> Dig(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<DigModel>(
                new ApiMethod(ApiV1Constants.LinkDig, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<DigModel> Cancel(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<DigModel>(
                new ApiMethod(ApiV1Constants.LinkCancel, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<DigModel> Bury(int linkId, int buryReason)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));
            if (buryReason <= 0) throw new ArgumentOutOfRangeException(nameof(buryReason));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId),
                new StringMethodParameter("param2", buryReason)
            };

            return Client.CallApiMethodWithAuth<DigModel>(
                new ApiMethod(ApiV1Constants.LinkBury, HttpMethod.Get, parameters, methodParameter)
                );
        }

        public Task<List<Comment>> Comments(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<List<Comment>>(
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

        public Task<DigModel> Digs(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<DigModel>(
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

        public Task<BooleanModel> Observe(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<BooleanModel>(
                new ApiMethod(ApiV1Constants.LinkObserve, HttpMethod.Post, parameters, methodParameter)
                );
        }

        public Task<BooleanModel> Favorite(int linkId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter>()
            {
                new StringMethodParameter("param1", linkId)
            };

            return Client.CallApiMethodWithAuth<BooleanModel>(
                new ApiMethod(ApiV1Constants.LinkFavorite, HttpMethod.Post, parameters, methodParameter)
                );
        }


    }
}