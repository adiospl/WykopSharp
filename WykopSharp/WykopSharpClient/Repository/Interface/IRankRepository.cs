using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharpClient.Enumerable;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IRankRepository
    {
        Task<List<Profile>> Index(RankOrder order);
    }
}