using System.Threading.Tasks;
using WykopSharpClient.Model;
using WykopSharpClient.Repository.Builder;

namespace WykopSharpClient.Repository.Interface
{
    public interface IRelatedRepository
    {
        Task<RecivedId> Add(int linkId, RelatedQuery query);
        Task<RecivedVote> Minus(int linkId, int relatedId);
        Task<RecivedVote> Plus(int linkId, int relatedId);
    }
}