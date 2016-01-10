using System.Collections.Generic;
using WykopSharp;

namespace WykopSharpClient.Repository.Builder
{
    public interface IQuery
    {
        SortedSet<PostParameter> GetQuery();
        void Build();
    }
}