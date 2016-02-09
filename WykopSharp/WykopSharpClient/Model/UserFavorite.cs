using Newtonsoft.Json;
using WykopSharp.Model;

namespace WykopSharpClient.Model
{
    public class UserFavorite : ErrorModel
    {
        [JsonProperty(PropertyName = "user_favorite")]
        public bool Favorite { get; set; }
    }
}
