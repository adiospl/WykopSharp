using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Builder;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_10")]
    public class RelatedRepository : AbstractRepository, IRelatedRepository
    {
        public RelatedRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<RecivedVote> Plus(int linkId, int relatedId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));
            if (relatedId <= 0) throw new ArgumentOutOfRangeException(nameof(relatedId));
            
            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", linkId),
                new StringMethodParameter("param2", relatedId)
            };

            return Client.CallApiMethodWithAuth<RecivedVote>(
                new ApiMethod(ApiV1Constants.RelatedPlus, HttpMethod.Get, parameters, methodParameters)
                );
        }

        public Task<RecivedVote> Minus(int linkId, int relatedId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));
            if (relatedId <= 0) throw new ArgumentOutOfRangeException(nameof(relatedId));

            var parameters = GetApiParameterSet();
            var methodParameters = new SortedSet<StringMethodParameter>
            {
                new StringMethodParameter("param1", linkId),
                new StringMethodParameter("param2", relatedId)
            };

            return Client.CallApiMethodWithAuth<RecivedVote>(
                new ApiMethod(ApiV1Constants.RelatedMinus, HttpMethod.Get, parameters, methodParameters)
                );
        }

        /*
            It returns id : false, but succeed
        */
        public Task<RecivedId> Add(int linkId, RelatedQuery query)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            var methodParameter = new SortedSet<StringMethodParameter> {new ApiParameter("param1", linkId)};

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.RelatedAdd, HttpMethod.Post, parameters, methodParameter, query.GetQuery())
                );
        }
    }
}