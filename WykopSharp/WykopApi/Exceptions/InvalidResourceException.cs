using System;

namespace WykopSharp.Exceptions
{
    public class InvalidResourceException : ApiException
    {
        public InvalidResourceException(int code) : base(code)
        {
        }

        public InvalidResourceException(string message, int code) : base(message, code)
        {
        }

        public InvalidResourceException(string message, Exception innerException, int code) : base(message, innerException, code)
        {
        }
    }
}
