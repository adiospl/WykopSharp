using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface ILinkRepository
    {
        Task<DigResponse> Bury(int linkId, int buryReason);
        Task<List<BuryReason>> BuryReasons();
        Task<DigResponse> Cancel(int linkId);
        Task<List<Comment>> Comments(int linkId);
        Task<DigResponse> Dig(int linkId);
        Task<DigResponse> Digs(int linkId);
        Task<BooleanResponse> Favorite(int linkId);
        Task<Link> Index(int linkId);
        Task<BooleanResponse> Observe(int linkId);
        Task<List<RelatedLink>> Related(int linkId);
        Task<List<Bury>> Reports(int linkId);
    }
}