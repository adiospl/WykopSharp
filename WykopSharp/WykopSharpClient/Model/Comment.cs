using System;
using Newtonsoft.Json;
using WykopSharp.Model;

namespace WykopSharpClient.Model
{
    public class Comment : ErrorModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

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

        [JsonProperty(PropertyName = "vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        [JsonProperty(PropertyName = "parent_id")]
        public int ParentId { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "embed")]
        public Embed Embed { get; set; }

        [JsonProperty(PropertyName = "link")]
        public Link Link { get; set; }

        public bool IsParent => Id == ParentId;
    }
}