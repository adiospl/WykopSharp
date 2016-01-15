using System.Collections.Generic;
using WykopSharp;

namespace WykopSharpClient.Repository.Builder
{
    public abstract class AbstractQuery : IQuery
    {

        protected readonly SortedSet<PostParameter> Query = new SortedSet<PostParameter>();

        public SortedSet<PostParameter> GetQuery()
        {
            Build();
            return Query;
        }

        public virtual void Build()
        {
        }
    }
}
