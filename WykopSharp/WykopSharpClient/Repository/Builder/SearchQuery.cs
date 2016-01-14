using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WykopSharp;
using WykopSharpClient.Enumerable.Search;

namespace WykopSharpClient.Repository.Builder
{
    public class SearchQuery : IQuery
    {
        private string _from;
        private string _sort;
        private string _to;
        private string _votes;

        private string _what;
        private string _when;

        private readonly SortedSet<PostParameter> _query = new SortedSet<PostParameter>();

        public void Build()
        {
            foreach (var p in Fields().Where(parameter => parameter != null))
            {
                if(!string.IsNullOrEmpty(p.Item2))
                    _query.Add(new StringPostParameter(p.Item1, p.Item2));
            }
        }

        public SortedSet<PostParameter> GetQuery()
        {
            return _query;
        }

        private IEnumerable<Tuple<string, string>> Fields()
        {
            yield return Tuple.Create("_what", _what);
            yield return Tuple.Create("_sort", _sort);
            yield return Tuple.Create("_when", _when);
            yield return Tuple.Create("_from", _from);
            yield return Tuple.Create("_to", _to);
            yield return Tuple.Create("_votes", _votes);
        }

        public SearchQuery WithWhat(What what)
        {
            _what = what.ToString().ToLower();
            return this;
        }

        public SearchQuery WithSort(Sort sort)
        {
            _sort = sort.ToString().ToLower();
            return this;
        }

        public SearchQuery WithWhen(When when)
        {
            _when = when.ToString().ToLower();
            return this;
        }

        public SearchQuery WithDateFrom(DateTime from)
        {
            _from = String.Format("yyyy/MM/dd", from);
            return this;
        }

        public SearchQuery WithDateTo(DateTime to)
        {
            _to = String.Format("yyyy/MM/dd", to);
            return this;
        }

        public SearchQuery WithVotes(int votes)
        {
            _votes = votes.ToString();
            return this;
        }
    }
}