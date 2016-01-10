using System;
using System.Net.Http;
using System.Threading.Tasks;
using WykopSharp;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Builder;

namespace WykopSharpClient.Repository
{
    [Repository]
    [WykopApiDoc("http://www.wykop.pl/dla-programistow/dokumentacja/#info6_10")]
    public class RelatedRepository : AbstractRepository
    {
        public RelatedRepository(WykopSharpClient client) : base(client)
        {
        }

        public Task<RecivedVote> Plus(int linkId, int relatedId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));
            if (relatedId <= 0) throw new ArgumentOutOfRangeException(nameof(relatedId));
            
            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("param1", linkId));
            parameters.Add(new ApiParameter("param2", relatedId));
            
            return Client.CallApiMethodWithAuth<RecivedVote>(
                new ApiMethod(ApiV1Constants.RelatedPlus, HttpMethod.Get, parameters)
                );
        }

        public Task<RecivedVote> Minus(int linkId, int relatedId)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));
            if (relatedId <= 0) throw new ArgumentOutOfRangeException(nameof(relatedId));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("param1", linkId));
            parameters.Add(new ApiParameter("param2", relatedId));

            return Client.CallApiMethodWithAuth<RecivedVote>(
                new ApiMethod(ApiV1Constants.RelatedMinus, HttpMethod.Get, parameters)
                );
        }

        public Task<RecivedId> Add(int linkId, RelatedQuery query)
        {
            if (linkId <= 0) throw new ArgumentOutOfRangeException(nameof(linkId));

            var parameters = GetApiParameterSet();
            parameters.Add(new ApiParameter("param1", linkId));

            return Client.CallApiMethodWithAuth<RecivedId>(
                new ApiMethod(ApiV1Constants.RelatedAdd, HttpMethod.Post, parameters, query.GetQuery())
                );
        }
    }
}