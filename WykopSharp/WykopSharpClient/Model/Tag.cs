using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WykopSharp.Model;

namespace WykopSharpClient.Model
{
    public class Counters : BaseModel
    {

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "entries")]
        public int Entries { get; set; }

        [JsonProperty(PropertyName = "links")]
        public int Links { get; set; }
    }

    public class Meta : BaseModel
    {

        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [JsonProperty(PropertyName = "is_observed")]
        public bool IsObserved { get; set; }

        [JsonProperty(PropertyName = "is_blocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty(PropertyName = "counters")]
        public Counters Counters { get; set; }
    }

    public class Tag : ErrorModel
    {
        [JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }

        [JsonConverter(typeof(WykopItemArrayTypeConverter))]
        [JsonProperty(PropertyName = "items")]
        public List<IWykopItem> Items { get; set; }
    }
}