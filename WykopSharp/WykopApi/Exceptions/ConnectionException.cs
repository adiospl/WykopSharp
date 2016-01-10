namespace WykopSharp.Exceptions
{
    public class ConnectionException : ApiException
    {
        public ConnectionException(int code) : base(code)
        {
        }

        public ConnectionException(string message, int code) : base(message, code)
        {
        }

        public ConnectionException(string message, System.Exception innerException, int code) : base(message, innerException, code)
        {
        }
    }
}
