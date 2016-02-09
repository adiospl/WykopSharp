using System.Collections.Generic;
using Newtonsoft.Json;
using WykopSharp.Model;

namespace WykopSharpClient.Model
{
    public class TopYear : ErrorModel
    {

        [JsonProperty(PropertyName = "1")]
        public List<Link> January { get; set; }

        [JsonProperty(PropertyName = "2")]
        public List<Link> February { get; set; }

        [JsonProperty(PropertyName = "3")]
        public List<Link> March { get; set; }

        [JsonProperty(PropertyName = "4")]
        public List<Link> April { get; set; }

        [JsonProperty(PropertyName = "5")]
        public List<Link> May { get; set; }

        [JsonProperty(PropertyName = "6")]
        public List<Link> June { get; set; }

        [JsonProperty(PropertyName = "7")]
        public List<Link> July { get; set; }

        [JsonProperty(PropertyName = "8")]
        public List<Link> August { get; set; }

        [JsonProperty(PropertyName = "9")]
        public List<Link> September { get; set; }

        [JsonProperty(PropertyName = "10")]
        public List<Link> October { get; set; }

        [JsonProperty(PropertyName = "11")]
        public List<Link> November { get; set; }

        [JsonProperty(PropertyName = "12")]
        public List<Link> December { get; set; }

    }
}
