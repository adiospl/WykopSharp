using System.Collections.Generic;
using WykopSharp;

namespace WykopSharpClient.Repository.Interface
{
    public interface IRepository
    {
        HashSet<ApiParameter> GetApiParameterSet();
    }
}