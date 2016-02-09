using System;
using Newtonsoft.Json;
using WykopSharp.Model;
using WykopSharpClient.Model.Constants;

namespace WykopSharpClient.Model
{
    public class Embed : ErrorModel
    {
        [JsonConverter(typeof(EmbedTypeConverter))]
        [JsonProperty(PropertyName = "type")]
        public EmbedType Type { get; set; }

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