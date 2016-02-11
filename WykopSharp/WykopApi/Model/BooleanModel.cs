namespace WykopSharp.Model
{

    public class BooleanModel : BaseModel
    {
        public BooleanModel()
        {
            
        }

        public BooleanModel(string response)
        {
            Success = response.Contains("true");
        }

        public bool Success { get; set; }
        
    }

}
