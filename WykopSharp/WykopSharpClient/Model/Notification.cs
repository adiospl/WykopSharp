using System;
using Newtonsoft.Json;
using WykopSharp.Model;
using WykopSharpClient.Model.Constants;

namespace WykopSharpClient.Model
{
    public class Notification : BaseResponse
    {
        [JsonProperty(PropertyName = "new")]
        public bool New;

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "author_group")]
        public int AuthorGroup { get; set; }

        [JsonProperty(PropertyName = "author_avatar")]
        public string AuthorAvatar { get; set; }

        [JsonProperty(PropertyName = "author_avatar_big")]
        public string AuthorAvatarBig { get; set; }

        [JsonProperty(PropertyName = "author_avatar_med")]
        public string AuthorAvatarMedium { get; set; }

        [JsonProperty(PropertyName = "author_avatar_lo")]
        public string AuthorAvatarLow { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(NotificationTypeConverter))]
        public NotificationType Type { get; set; }

        [JsonProperty(PropertyName = "entry")]
        public Entry Entry { get; set; }

        [JsonProperty(PropertyName = "link")]
        public Link Link { get; set; }

        [JsonProperty(PropertyName = "comment")]
        public object Comment { get; set; }

        [JsonProperty(PropertyName = "url")]
        public Uri Url { get; set; }
    }
    
}