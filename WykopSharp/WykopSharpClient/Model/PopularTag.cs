using Newtonsoft.Json;

namespace WykopSharpClient.Model
{
    public class PopularTag
    {
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
    }
}
