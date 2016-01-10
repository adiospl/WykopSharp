using System;

namespace WykopSharp.Exceptions
{
    public class UnknownApiException : ApiException
    {
        public UnknownApiException(int code) : base(code)
        {
        }

        public UnknownApiException(string message, int code) : base(message, code)
        {
        }

        public UnknownApiException(string message, Exception innerException, int code) : base(message, innerException, code)
        {
        }
    }
}
