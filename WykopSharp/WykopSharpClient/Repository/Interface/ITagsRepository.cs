using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface ITagsRepository
    {
        Task<List<PopularTag>> Popular();
    }
}