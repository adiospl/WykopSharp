using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WykopSharpClient.Model.Constants
{
    public enum UserVote
    {
        Minus = -1,
        Plus = 1,
        None = 0
    }

    public class UserVoteConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.Value.ToString())
            {
                case "-1":
                    return UserVote.Minus;
                case "1":
                    return UserVote.Plus;
                case "false":
                default:
                    return UserVote.None;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType is string;
        }
    }
}
