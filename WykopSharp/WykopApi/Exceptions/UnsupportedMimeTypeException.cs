using System;

namespace WykopSharp.Exceptions
{
    public class UnsupportedMimeTypeException : Exception
    {
        public UnsupportedMimeTypeException()
        {
        }

        public UnsupportedMimeTypeException(string message) : base(message)
        {
        }

        public UnsupportedMimeTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
