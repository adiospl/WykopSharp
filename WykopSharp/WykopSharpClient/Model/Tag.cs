using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WykopSharp.Model;

namespace WykopSharpClient.Model
{
    public class Counters : BaseModel
    {

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "entries")]
        public int Entries { get; set; }

        [JsonProperty(PropertyName = "links")]
        public int Links { get; set; }
    }

    public class Meta : BaseModel
    {

        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [JsonProperty(PropertyName = "is_observed")]
        public bool IsObserved { get; set; }

        [JsonProperty(PropertyName = "is_blocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty(PropertyName = "counters")]
        public Counters Counters { get; set; }
    }

    public class TagItem : BaseModel
    {

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "author_avatar")]
        public string AuthorAvatar { get; set; }

        [JsonProperty(PropertyName = "author_avatar_big")]
        public string AuthorAvatarBig { get; set; }

        [JsonProperty(PropertyName = "author_avatar_med")]
        public string AuthorAvatarMed { get; set; }

        [JsonProperty(PropertyName = "author_avatar_lo")]
        public string AuthorAvatarLo { get; set; }

        [JsonProperty(PropertyName = "author_group")]
        public int AuthorGroup { get; set; }

        [JsonProperty(PropertyName = "author_sex")]
        public string AuthorSex { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        [JsonProperty(PropertyName = "source")]
        public object Source { get; set; }

        [JsonProperty(PropertyName = "url")]
        public Uri Url { get; set; }

        [JsonProperty(PropertyName = "receiver")]
        public object Receiver { get; set; }

        [JsonProperty(PropertyName = "receiver_avatar")]
        public object ReceiverAvatar { get; set; }

        [JsonProperty(PropertyName = "receiver_avatar_big")]
        public object ReceiverAvatarBig { get; set; }

        [JsonProperty(PropertyName = "receiver_avatar_med")]
        public object ReceiverAvatarMed { get; set; }

        [JsonProperty(PropertyName = "receiver_avatar_lo")]
        public object ReceiverAvatarLo { get; set; }

        [JsonProperty(PropertyName = "receiver_group")]
        public object ReceiverGroup { get; set; }

        [JsonProperty(PropertyName = "receiver_sex")]
        public object ReceiverSex { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public List<object> Comments { get; set; }

        [JsonProperty(PropertyName = "blocked")]
        public bool Blocked { get; set; }

        [JsonProperty(PropertyName = "vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty(PropertyName = "user_vote")]
        public object UserVote { get; set; }

        [JsonProperty(PropertyName = "user_favorite")]
        public bool UserFavorite { get; set; }

        [JsonProperty(PropertyName = "voters")]
        public List<object> Voters { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "embed")]
        public Embed Embed { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        [JsonProperty(PropertyName = "violation_url")]
        public string ViolationUrl { get; set; }

        [JsonProperty(PropertyName = "can_comment")]
        public object CanComment { get; set; }

        [JsonProperty(PropertyName = "app")]
        public string App { get; set; }

        [JsonProperty(PropertyName = "comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        [JsonProperty(PropertyName = "source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty(PropertyName = "report_count")]
        public int? ReportCount { get; set; }

        [JsonProperty(PropertyName = "related_count")]
        public int? RelatedCount { get; set; }

        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        [JsonProperty(PropertyName = "preview")]
        public object Preview { get; set; }

        [JsonProperty(PropertyName = "user_observe")]
        public bool? UserObserve { get; set; }

        [JsonProperty(PropertyName = "user_lists")]
        public List<object> UserLists { get; set; }

        [JsonProperty(PropertyName = "plus18")]
        public bool? Plus18 { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "can_vote")]
        public bool? CanVote { get; set; }

        [JsonProperty(PropertyName = "has_own_content")]
        public bool? HasOwnContent { get; set; }

        [JsonProperty(PropertyName = "is_hot")]
        public bool? IsHot { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "category_name")]
        public string CategoryName { get; set; }

        [JsonProperty(PropertyName = "info")]
        public object Info { get; set; }

        [JsonProperty(PropertyName = "commented")]
        public bool? Commented { get; set; }
    }

    public class Tag : ErrorModel
    {
        [JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<TagItem> Items { get; set; }
    }
}