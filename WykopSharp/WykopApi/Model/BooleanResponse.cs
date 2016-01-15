namespace WykopSharp.Model
{

    public class BooleanResponse : BaseResponse
    {
        public BooleanResponse(string response)
        {
            Success = response.Contains("true");
        }

        public bool Success { get; set; }
        
    }

}
