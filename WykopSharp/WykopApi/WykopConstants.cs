using System.Collections.Generic;

namespace WykopSharp
{
    public static class WykopConstants
    {
        public enum AllowedApiKeys
        {
            UserKey,
            Page,
            Sort,
            Period,
            Group,
            Output,
            Format,
            Redirect,
            Secure
        }

        public const string UserAgent = "WykopSharp";
        public const string AppDomain = "http://a.wykop.pl/";
        public const string Format = "application/json";
        public const string Output = "clear";
        public const string Charset = "UTF-8";
        public const string CacheControl = "no-cache";

        public static readonly Dictionary<AllowedApiKeys, string> AllowedApiParameters = new Dictionary
            <AllowedApiKeys, string>
        {
            {AllowedApiKeys.UserKey, "userkey"},
            {AllowedApiKeys.Page, "page"},
            {AllowedApiKeys.Sort, "sort"},
            {AllowedApiKeys.Period, "period"},
            {AllowedApiKeys.Group, "group"},
            {AllowedApiKeys.Output, "output"},
            {AllowedApiKeys.Format, "format"},
            {AllowedApiKeys.Redirect, "redirect"},
            {AllowedApiKeys.Secure, "secure"}
        };
    }
}