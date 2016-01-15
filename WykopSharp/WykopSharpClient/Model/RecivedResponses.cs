using Newtonsoft.Json;
using WykopSharp.Model;

namespace WykopSharpClient.Model
{
    public class RecivedId : BaseResponse
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
    }

    public class RecivedVote : BaseResponse
    {
        [JsonProperty(PropertyName = "vote")]
        public int Vote { get; set; }
    }

    public class RecivedCount : BaseResponse
    {

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

    }
    
    public class DigResponse : BaseResponse
    {

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "vote")]
        public int Vote { get; set; }

        [JsonProperty(PropertyName = "report_count")]
        public int ReportCount { get; set; }
    }

}