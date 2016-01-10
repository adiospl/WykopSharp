using System;

namespace WykopSharp.Exceptions
{
    public class UnsupportedParameterException : Exception
    {
        public UnsupportedParameterException()
        {
        }

        public UnsupportedParameterException(string message)
            : base(message)
        {
        }

        public UnsupportedParameterException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}