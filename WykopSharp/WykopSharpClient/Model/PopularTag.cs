using Newtonsoft.Json;
using WykopSharp.Model;

namespace WykopSharpClient.Model
{
    public class PopularTag : ErrorModel
    {
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
    }
}
