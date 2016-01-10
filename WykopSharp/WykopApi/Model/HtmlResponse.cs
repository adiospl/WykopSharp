using System;

namespace WykopSharp.Model
{
    public class HtmlResponse
    {
        public string Html { private get; set; }

        public TResult GetResult<TResult>() where TResult: class
        {
            return (TResult) Convert.ChangeType(Html, Type.GetTypeCode(typeof(TResult)));
        }
    }
}
