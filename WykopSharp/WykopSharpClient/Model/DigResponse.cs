using Newtonsoft.Json;

namespace WykopSharpClient.Model
{
    public class DigResponse
    {

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "vote")]
        public int Vote { get; set; }

    }
}
