using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Builder;
using WykopSharpClient.Repository.Interface;

namespace WykopSharpClient.Repository.Fake
{
    public class FakeRelatedRepository : IRelatedRepository
    {
        public Task<RecivedId> Add(int linkId, RelatedQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedVote> Minus(int linkId, int relatedId)
        {
            throw new NotImplementedException();
        }

        public Task<RecivedVote> Plus(int linkId, int relatedId)
        {
            throw new NotImplementedException();
        }
    }
}
