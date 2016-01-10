using System;
using System.Collections.Generic;
using System.Linq;
using WykopSharp;

namespace WykopSharpClient.Repository.Builder
{
    public class RelatedQuery : IQuery
    {
        private string _plus18;
        private string _title;

        private string _url;
        public static int TitleMinLength => 6;
        public static int TitleMaxLength => 80;

        private SortedSet<PostParameter> _query =>
            _query ?? new SortedSet<PostParameter>();

        public SortedSet<PostParameter> GetQuery()
        {
            return _query;
        }

        public void Build()
        {
            foreach (var p in Fields().Where(parameter => parameter != null))
            {
                _query.Add(new StringPostParameter(p.Item1, p.Item2));
            }
        }

        private IEnumerable<Tuple<string, string>> Fields()
        {
            yield return Tuple.Create("_url", _url);
            yield return Tuple.Create("_title", _title);
            yield return Tuple.Create("_plus18", _plus18);
        }

        public RelatedQuery WithUrl(Uri url)
        {
            _url = url.ToString();
            return this;
        }

        public RelatedQuery WithTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Argument is null or whitespace", nameof(title));
            if (title.Length < TitleMinLength)
                throw new ArgumentException("Argument is shorter than {TitleMinLength}", nameof(title));
            if (title.Length > TitleMaxLength)
                throw new ArgumentException("Argument is longer than {TitleMaxLength}", nameof(title));

            _title = title;
            return this;
        }

        public RelatedQuery WithPlus18(bool plus18)
        {
            _plus18 = plus18 ? "1" : "0";
            return this;
        }
    }
}