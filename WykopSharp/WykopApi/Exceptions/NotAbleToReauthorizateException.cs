using System;

namespace WykopSharp.Exceptions
{
    public class NotAbleToReauthorizateException : Exception
    {
        public NotAbleToReauthorizateException()
        {
        }

        public NotAbleToReauthorizateException(string message) : base(message)
        {
        }

        public NotAbleToReauthorizateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
