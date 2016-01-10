using System;

namespace WykopSharp.Exceptions
{
    public class SignatureException : ApiException
    {
        public SignatureException(int code) : base(code)
        {
        }

        public SignatureException(string message, int code) : base(message, code)
        {
        }

        public SignatureException(string message, Exception innerException, int code) : base(message, innerException, code)
        {
        }
    }
}
