using System;
using Newtonsoft.Json;

namespace WykopSharpClient.Model.Constants
{
    public enum EmbedType
    {
        Type,
        Preview,
        Url,
        Source,
        Plus18,
        None
    }

    public class EmbedTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.Value as string)
            {
                case "type":
                    return EmbedType.Type;
                case "preview":
                    return EmbedType.Preview;
                case "url":
                    return EmbedType.Url;
                case "source":
                    return EmbedType.Source;
                case "plus18":
                    return EmbedType.Plus18;
                default:
                    return EmbedType.None;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType is string;
        }
    }
}
