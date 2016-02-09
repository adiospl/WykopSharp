using System;
using Newtonsoft.Json;
using WykopSharp.Model;
using WykopSharpClient.Model.Constants;

namespace WykopSharpClient.Model
{
    public class Voter : ErrorModel
    {
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
        public string Date { get; set; }
    }
}
