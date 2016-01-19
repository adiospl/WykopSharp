using System.Collections.Generic;
using System.Threading.Tasks;
using WykopSharpClient.Enumerable;
using WykopSharpClient.Model;

namespace WykopSharpClient.Repository.Interface
{
    public interface IStreamRepository
    {
        Task<List<Entry>> Hot(Period period, int page = 1);
        Task<List<Entry>> Index(int page = 1);
    }
}