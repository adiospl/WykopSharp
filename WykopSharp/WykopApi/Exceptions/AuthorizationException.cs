using System;

namespace WykopSharp.Exceptions
{
    public class AuthorizationException : ApiException
    {
        public int Resume { get; set; } = 0;

        public AuthorizationException(int code) : base(code)
        {
            Resume++;
        }

        public AuthorizationException(string message, int code) : base(message, code)
        {
            Resume++;
        }

        public AuthorizationException(string message, Exception innerException, int code) : base(message, innerException, code)
        {
            Resume++;
        }
    }
}
