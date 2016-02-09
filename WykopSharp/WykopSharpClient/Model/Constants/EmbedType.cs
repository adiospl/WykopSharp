using System;
using Newtonsoft.Json;

namespace WykopSharpClient.Model.Constants
{
    public enum EmbedType
    {
        Image,
        Video,
        None
    }

    public class EmbedTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            //throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.Value as string)
            {
                case "image":
                    return EmbedType.Image;
                case "video":
                    return EmbedType.Video;
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
