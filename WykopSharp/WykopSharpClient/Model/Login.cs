using System;
using Newtonsoft.Json;

namespace WykopSharpClient.Model
{
    public class Login
    {
        [JsonProperty(PropertyName = "login")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "public_email")]
        public string PublicEmail { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "www")]
        public string Website { get; set; }

        [JsonProperty(PropertyName = "jabber")]
        public string Jabber { get; set; }

        [JsonProperty(PropertyName = "gg")]
        public string Gg { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "about")]
        public string About { get; set; }

        [JsonProperty(PropertyName = "author_group")]
        public int AuthorGroup { get; set; }

        [JsonProperty(PropertyName = "links_added")]
        public int LinksAdded { get; set; }

        [JsonProperty(PropertyName = "links_published")]
        public int LinksPublished { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public int Comments { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public int Rank { get; set; }

        [JsonProperty(PropertyName = "followers")]
        public int Followers { get; set; }

        [JsonProperty(PropertyName = "following")]
        public int Following { get; set; }

        [JsonProperty(PropertyName = "entries")]
        public int Entries { get; set; }

        [JsonProperty(PropertyName = "entries_comments")]
        public int EntriesComments { get; set; }

        [JsonProperty(PropertyName = "diggs")]
        public int Diggs { get; set; }

        [JsonProperty(PropertyName = "buries")]
        public int Buries { get; set; }

        [JsonProperty(PropertyName = "groups")]
        public int Groups { get; set; }

        [JsonProperty(PropertyName = "related_links")]
        public int RelatedLinks { get; set; }

        [JsonProperty(PropertyName = "signup_date")]
        public string SignupDate { get; set; }

        [JsonProperty(PropertyName = "author_avatar")]
        public string AuthorAvatar { get; set; }

        [JsonProperty(PropertyName = "author_avatar_big")]
        public string AuthorAvatarBig { get; set; }

        [JsonProperty(PropertyName = "author_avatar_med")]
        public string AuthorAvatarMedium { get; set; }

        [JsonProperty(PropertyName = "author_avatar_lo")]
        public string AuthorAvatarLow { get; set; }

        [JsonProperty(PropertyName = "is_observed")]
        public object IsObserved { get; set; }

        [JsonProperty(PropertyName = "is_blocked")]
        public object IsBlocked { get; set; }

        [JsonProperty(PropertyName = "sex")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "url")]
        public Uri Url { get; set; }

        [JsonProperty(PropertyName = "violation_url")]
        public object ViolationUrl { get; set; }

        [JsonProperty(PropertyName = "userkey")]
        public string Userkey { get; set; }
    }
}