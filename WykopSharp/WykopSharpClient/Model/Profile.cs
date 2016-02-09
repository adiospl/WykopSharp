using System;
using Newtonsoft.Json;
using WykopSharp.Model;

namespace WykopSharpClient.Model
{
    public class Profile : ErrorModel
    {
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "public_email")]
        public string PublicEmail { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "www")]
        public Uri Website { get; set; }

        [JsonProperty(PropertyName = "Jabber")]
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

        [JsonProperty(PropertyName = "Entries_comments")]
        public int EntriesComments { get; set; }

        [JsonProperty(PropertyName = "diggs")]
        public int Diggs { get; set; }

        [JsonProperty(PropertyName = "buries")]
        public object Buries { get; set; }

        [JsonProperty(PropertyName = "Groups")]
        public int Groups { get; set; }

        [JsonProperty(PropertyName = "related_links")]
        public int RelatedLinks { get; set; }

        [JsonProperty(PropertyName = "signup_date")]
        public string SignupDate { get; set; }

        [JsonProperty(PropertyName = "avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty(PropertyName = "avatar_big")]
        public Uri AvatarBig { get; set; }

        [JsonProperty(PropertyName = "avatar_med")]
        public Uri AvatarMedium { get; set; }

        [JsonProperty(PropertyName = "avatar_lo")]
        public Uri AvatarLow { get; set; }

        [JsonProperty(PropertyName = "is_observed")]
        public bool IsObserved { get; set; }

        [JsonProperty(PropertyName = "is_blocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty(PropertyName = "sex")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "url")]
        public Uri Url { get; set; }

        [JsonProperty(PropertyName = "violation_url")]
        public Uri ViolationUrl { get; set; }
    }
}