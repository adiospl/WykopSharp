using System;

namespace WykopSharp.Exceptions
{
    public class InvalidResponseException : ApiException
    {
        public InvalidResponseException(int code) : base(code)
        {
        }

        public InvalidResponseException(string message, int code) : base(message, code)
        {
        }

        public InvalidResponseException(string message, Exception innerException, int code) : base(message, innerException, code)
        {
        }
    }
}
