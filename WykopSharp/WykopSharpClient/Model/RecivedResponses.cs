using Newtonsoft.Json;

namespace WykopSharpClient.Model
{
    public class RecivedId
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
    }

    public class RecivedVote
    {
        [JsonProperty(PropertyName = "vote")]
        public int Vote { get; set; }
    }
}