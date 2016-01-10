using System;

namespace WykopSharp.Exceptions
{
    public class UnsupportedHttpMethodException : Exception
    {
        public UnsupportedHttpMethodException()
        {
        }

        public UnsupportedHttpMethodException(string message) : base(message)
        {
        }

        public UnsupportedHttpMethodException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}