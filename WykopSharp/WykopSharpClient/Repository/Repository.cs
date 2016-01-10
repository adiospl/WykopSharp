using System;

namespace WykopSharpClient.Repository
{
    internal class Repository : Attribute
    {
    }

    internal class WykopApiDoc : Attribute
    {
        public WykopApiDoc(string url)
        {
            Url = url;
        }

        public string Url { get; }
    }
}