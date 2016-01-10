namespace WykopSharpClient.Exception
{
    public class ApiClientIsNotSupportedException : System.Exception
    {
        public ApiClientIsNotSupportedException()
        {
        }

        public ApiClientIsNotSupportedException(string message) : base(message)
        {
        }

        public ApiClientIsNotSupportedException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
