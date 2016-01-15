using Newtonsoft.Json;

namespace WykopSharpClient.Model
{
    public class UserFavorite
    {
        [JsonProperty(PropertyName = "user_favorite")]
        public bool Favorite { get; set; }
    }
}
