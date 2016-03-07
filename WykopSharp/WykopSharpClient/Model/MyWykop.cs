using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using WykopSharpClient.Model.Constants;

namespace WykopSharpClient.Model
{
    [JsonConverter(typeof(WykopItemArrayTypeConverter))]
    public class MyWykop
    {
        [JsonConverter(typeof(WykopItemArrayTypeConverter))]
        [JsonProperty(PropertyName = "items")]
        public List<IWykopItem> Items { get; set; }
    }
}