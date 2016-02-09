using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharp.Model;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface ILinkRepository
    {
        Task<DigModel> Bury(int linkId, int buryReason);
        Task<List<BuryReason>> BuryReasons();
        Task<DigModel> Cancel(int linkId);
        Task<List<Comment>> Comments(int linkId);
        Task<DigModel> Dig(int linkId);
        Task<DigModel> Digs(int linkId);
        Task<BooleanModel> Favorite(int linkId);
        Task<Link> Index(int linkId);
        Task<BooleanModel> Observe(int linkId);
        Task<List<RelatedLink>> Related(int linkId);
        Task<List<Bury>> Reports(int linkId);
    }
}