using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WykopSharp.Model;
using WykopSharpClient.Model.Constants;

namespace WykopSharpClient.Model
{
    public class Entry : ErrorModel, IWykopItem
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "author_avatar")]
        public Uri AuthorAvatar { get; set; }

        [JsonProperty(PropertyName = "author_avatar_big")]
        public Uri AuthorAvatarBig { get; set; }

        [JsonProperty(PropertyName = "author_avatar_med")]
        public Uri AuthorAvatarMed { get; set; }

        [JsonProperty(PropertyName = "author_avatar_lo")]
        public Uri AuthorAvatarLo { get; set; }

        [JsonProperty(PropertyName = "author_group")]
        public UserType AuthorGroup { get; set; }

        [JsonProperty(PropertyName = "author_sex")]
        public string AuthorSex { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        [JsonProperty(PropertyName = "source")]
        public Uri Source { get; set; }

        [JsonProperty(PropertyName = "url")]
        public Uri Url { get; set; }

        [JsonProperty(PropertyName = "receiver")]
        public string Receiver { get; set; }

        [JsonProperty(PropertyName = "receiver_avatar")]
        public Uri ReceiverAvatar { get; set; }

        [JsonProperty(PropertyName = "receiver_avatar_big")]
        public Uri ReceiverAvatarBig { get; set; }

        [JsonProperty(PropertyName = "receiver_avatar_med")]
        public Uri ReceiverAvatarMed { get; set; }

        [JsonProperty(PropertyName = "receiver_avatar_lo")]
        public Uri ReceiverAvatarLo { get; set; }

        [JsonProperty(PropertyName = "receiver_group")]
        public object ReceiverGroup { get; set; }

        [JsonProperty(PropertyName = "receiver_sex")]
        public string ReceiverSex { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public List<EntryComment> Comments { get; set; }

        [JsonProperty(PropertyName = "blocked")]
        public bool Blocked { get; set; }

        [JsonProperty(PropertyName = "vote_count")]
        public int VoteCount { get; set; }

        [JsonConverter(typeof(DigStatusConverter))]
        [JsonProperty(PropertyName = "user_vote")]
        public DigStatus UserVote { get; set; }

        [JsonProperty(PropertyName = "user_favorite")]
        public bool UserFavorite { get; set; }

        [JsonProperty(PropertyName = "voters")]
        public List<Voter> Voters { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "embed")]
        public Embed Embed { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        [JsonProperty(PropertyName = "violation_url")]
        public Uri ViolationUrl { get; set; }

        [JsonProperty(PropertyName = "can_comment")]
        public object CanComment { get; set; }

        [JsonProperty(PropertyName = "app")]
        public string App { get; set; }

        [JsonProperty(PropertyName = "comment_count")]
        public int CommentCount { get; set; }
        
    }
}