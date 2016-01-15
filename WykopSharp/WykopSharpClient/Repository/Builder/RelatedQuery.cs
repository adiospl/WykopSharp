using System;
using System.Collections.Generic;
using System.Linq;
using WykopSharp;

namespace WykopSharpClient.Repository.Builder
{
    public class RelatedQuery : AbstractQuery
    {
        private string _plus18;
        private string _title;

        private string _url;
        public static int TitleMinLength => 6;
        public static int TitleMaxLength => 80;
        
        public override void Build()
        {
            foreach (var p in Fields().Where(parameter => parameter != null))
            {
                Query.Add(new StringPostParameter(p.Item1, p.Item2));
            }
        }

        private IEnumerable<Tuple<string, string>> Fields()
        {
            yield return Tuple.Create("url", _url);
            yield return Tuple.Create("title", _title);
            yield return Tuple.Create("plus18", _plus18);
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