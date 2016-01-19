using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharpClient.Enumerable.Links;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IPopularRepository
    {
        Task<List<Link>> Promoted(int page, PromotedSort promotedSort);
        Task<List<Link>> Upcomming(int page, PromotedSort promotedSort);
    }
}