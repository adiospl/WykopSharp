using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WykopSharpClient.Model.Constants
{
    public enum CommentStatus
    {
        Own, New, Readed, Unknown
    }

    public class CommentStatusConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.Value as string)
            {
                case "own":
                    return CommentStatus.Own;
                case "new":
                    return CommentStatus.New;
                case "readed":
                    return CommentStatus.Readed;
                default:
                    return CommentStatus.Unknown;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType is string;
        }
    }
}
