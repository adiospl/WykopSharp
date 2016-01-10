namespace WykopSharp.Exceptions
{
    public class CreditentialsException : ApiException
    {
        public CreditentialsException(int code) : base(code)
        {
        }

        public CreditentialsException(string message, int code) : base(message, code)
        {
        }

        public CreditentialsException(string message, System.Exception innerException, int code) : base(message, innerException, code)
        {
        }
    }
}
