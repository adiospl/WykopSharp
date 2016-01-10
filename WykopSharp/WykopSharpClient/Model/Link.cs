using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WykopSharpClient.Model
{
    public class Link
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        [JsonProperty(PropertyName = "url")]
        public Uri Url { get; set; }

        [JsonProperty(PropertyName = "source_url")]
        public Uri SourceUrl { get; set; }

        [JsonProperty(PropertyName = "vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty(PropertyName = "comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty(PropertyName = "report_count")]
        public int ReportCount { get; set; }

        [JsonProperty(PropertyName = "related_count")]
        public int RelatedCount { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "author_group")]
        public int AuthorGroup { get; set; }

        [JsonProperty(PropertyName = "author_avatar")]
        public Uri AuthorAvatar { get; set; }

        [JsonProperty(PropertyName = "author_avatar_big")]
        public Uri AuthorAvatarBig { get; set; }

        [JsonProperty(PropertyName = "author_avatar_med")]
        public Uri AuthorAvatarMedium { get; set; }

        [JsonProperty(PropertyName = "author_avatar_lo")]
        public Uri AuthorAvatarLow { get; set; }

        [JsonProperty(PropertyName = "author_sex")]
        public string AuthorGender { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        [JsonProperty(PropertyName = "preview")]
        public string Preview { get; set; }

        [JsonProperty(PropertyName = "user_vote")]
        public string UserVote { get; set; }

        [JsonProperty(PropertyName = "user_favorite")]
        public bool UserFavorite { get; set; }

        [JsonProperty(PropertyName = "user_observe")]
        public bool UserObserve { get; set; }

        [JsonProperty(PropertyName = "user_lists")]
        public List<object> UserLists { get; set; }

        [JsonProperty(PropertyName = "plus18")]
        public bool Plus18 { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "can_vote")]
        public bool CanVote { get; set; }

        [JsonProperty(PropertyName = "has_own_content")]
        public bool HasOwnContent { get; set; }

        [JsonProperty(PropertyName = "is_hot")]
        public bool IsHot { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "category_name")]
        public string CategoryName { get; set; }

        [JsonProperty(PropertyName = "violation_url")]
        public Uri ViolationUrl { get; set; }

        [JsonProperty(PropertyName = "info")]
        public object Info { get; set; }

        [JsonProperty(PropertyName = "app")]
        public object App { get; set; }
    }
}