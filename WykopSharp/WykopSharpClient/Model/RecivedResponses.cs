using Newtonsoft.Json;
using WykopSharp.Model;

namespace WykopSharpClient.Model
{
    public class RecivedId : ErrorModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
    }

    public class RecivedVote : ErrorModel
    {
        [JsonProperty(PropertyName = "vote")]
        public int Vote { get; set; }

        [JsonProperty(PropertyName = "vote_plus")]
        public int VotePlus { get; set; }

        [JsonProperty(PropertyName = "vote_minus")]
        public int VoteMinus { get; set; }
    }

    public class RecivedCount : ErrorModel
    {

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

    }
    
    public class DigModel : ErrorModel
    {

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "vote")]
        public int Vote { get; set; }

        [JsonProperty(PropertyName = "report_count")]
        public int ReportCount { get; set; }
    }

}