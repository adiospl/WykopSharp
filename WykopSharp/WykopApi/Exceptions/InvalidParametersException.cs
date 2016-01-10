using System;

namespace WykopSharp.Exceptions
{
    public class InvalidParametersException : ApiException
    {
        public InvalidParametersException(int code) : base(code)
        {
        }

        public InvalidParametersException(string message, int code) : base(message, code)
        {
        }

        public InvalidParametersException(string message, Exception innerException, int code) : base(message, innerException, code)
        {
        }
    }
}
