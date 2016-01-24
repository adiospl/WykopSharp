using System;
using Newtonsoft.Json;

namespace WykopSharpClient.Model.Constants
{
    public enum DigStatus
    {
        Dig, Bury, False
    }

    public class DigStatusConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.Value as string)
            {
                case "dig":
                    return DigStatus.Dig;
                case "bury":
                    return DigStatus.Bury;
                case "false":
                default:
                    return DigStatus.False;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType is string;
        }
    }
}
