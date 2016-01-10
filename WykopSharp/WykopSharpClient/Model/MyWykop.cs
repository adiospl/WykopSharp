using System.Collections.Generic;
using Newtonsoft.Json;

namespace WykopSharpClient.Model
{
    public class MyWykop
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public List<Comment> Comments { get; set; }

        [JsonProperty(PropertyName = "commented")]
        public bool Commented { get; set; }

        [JsonProperty(PropertyName = "entry")]
        public Entry Entry { get; set; }
    }
}