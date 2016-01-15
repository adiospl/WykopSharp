using System;
using Newtonsoft.Json;

namespace WykopSharpClient.Model.Constants
{
    public enum ConversationStatus
    {
        New,
        Read,
        None
    }

    public class ConversationStatusConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType is string;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.Value as string)
            {
                case "new":
                    return ConversationStatus.New;
                case "read":
                    return ConversationStatus.Read;
                default:
                    return ConversationStatus.None;

            }
        }
    }
}