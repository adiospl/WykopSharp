using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Collections;
using Newtonsoft.Json;

namespace WykopSharpClient.Model.Constants
{
    public enum WykopType
    {
        Link, Entry, None
    }

    public class WykopTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.Value as string)
            {
                case "link":
                    return WykopType.Link;
                case "entry":
                    return WykopType.Entry;
                default:
                    return WykopType.None;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType is string;
        }
    }

}
