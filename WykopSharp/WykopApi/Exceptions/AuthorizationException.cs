using System;

namespace WykopSharp.Exceptions
{
    public class AuthorizationException : ApiException
    {

        public AuthorizationException(int code) : base(code)
        {
        }

        public AuthorizationException(string message, int code) : base(message, code)
        {
        }

        public AuthorizationException(string message, Exception innerException, int code) : base(message, innerException, code)
        {
        }
    }
}
