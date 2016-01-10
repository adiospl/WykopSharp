using System;
using Newtonsoft.Json;

namespace WykopSharpClient.Model
{
    public class ConversationList
    {
        [JsonProperty(PropertyName = "last_update")]
        public DateTime LastUpdate { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "author_avatar")]
        public Uri AuthorAvatar { get; set; }

        [JsonProperty(PropertyName = "author_avatar_med")]
        public Uri AuthorAvatarMedium { get; set; }

        [JsonProperty(PropertyName = "author_avatar_lo")]
        public Uri AuthorAvatarLow { get; set; }

        [JsonProperty(PropertyName = "author_group")]
        public int AuthorGroup { get; set; }

        [JsonProperty(PropertyName = "author_sex")]
        public string AuthorGender { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}