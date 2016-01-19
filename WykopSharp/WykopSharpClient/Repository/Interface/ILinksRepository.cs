using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharpClient.Enumerable.Links;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface ILinksRepository
    {
        Task<List<Link>> Promoted(int page, PromotedSort sort);
        Task<List<Link>> Upcomming(int page, UpcommingSort sort);
    }
}