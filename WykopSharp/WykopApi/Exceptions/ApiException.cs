namespace WykopSharp.Exceptions
{
    public class ApiException : System.Exception
    {
        public int Code;

        public ApiException(int code)
        {
            Code = code;
        }

        public ApiException(string message, int code) : base(message)
        {
            Code = code;
        }

        public ApiException(string message, System.Exception innerException, int code) : base(message, innerException)
        {
            Code = code;
        }
    }
}
