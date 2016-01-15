using System;
using Newtonsoft.Json;

namespace WykopSharpClient.Model.Constants
{
    public enum NotificationType
    {
        Register,
        Observe,
        Unobserve,
        EntryCommentDirected,
        EntryDirected,
        EntryTag,
        LinkCommentDirected,
        LinkPromoted,
        LinkDirected,
        System,
        Badge,
        SupportAnswer,
        ChannelRequest,
        ChannelAccepted,
        ChannelRejected,
        PrivateMessage,
        None
    }

    public class NotificationTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            NotificationType value;

            switch (reader.Value as string)
            {
                case "register":
                    value = NotificationType.Register;
                    break;
                case "observe":
                    value = NotificationType.Observe;
                    break;
                case "unobserve":
                    value = NotificationType.Unobserve;
                    break;
                case "entry_comment_directed":
                    value = NotificationType.EntryCommentDirected;
                    break;
                case "entry_directed":
                    value = NotificationType.EntryDirected;
                    break;
                case "entry_tag":
                    value = NotificationType.EntryTag;
                    break;
                case "link_comment_directed":
                    value = NotificationType.LinkCommentDirected;
                    break;
                case "link_promoted":
                    value = NotificationType.LinkPromoted;
                    break;
                case "link_directed":
                    value = NotificationType.LinkDirected;
                    break;
                case "system":
                    value = NotificationType.System;
                    break;
                case "badge":
                    value = NotificationType.Badge;
                    break;
                case "support_answer":
                    value = NotificationType.SupportAnswer;
                    break;
                case "channel_request":
                    value = NotificationType.ChannelRequest;
                    break;
                case "channel_accepted":
                    value = NotificationType.ChannelAccepted;
                    break;
                case "channel_rejected":
                    value = NotificationType.ChannelRejected;
                    break;
                case "pm":
                    value = NotificationType.PrivateMessage;
                    break;
                default:
                    value = NotificationType.None;
                    break;
            }

            return value;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType is string;
        }
    }
    
}
