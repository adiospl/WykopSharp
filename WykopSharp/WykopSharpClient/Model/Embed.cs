using System;
using Newtonsoft.Json;

namespace WykopSharpClient.Model
{
    public class Embed
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "preview")]
        public Uri Preview { get; set; }

        [JsonProperty(PropertyName = "url")]
        public Uri Url { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "plus18")]
        public bool Plus18 { get; set; }
    }
}