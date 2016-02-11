using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using WykopSharpClient.Model.Constants;

namespace WykopSharpClient.Model
{
    public interface IWykopItem
    {
        [JsonProperty(PropertyName = "id")]
        int Id { get; set; }

        [JsonProperty(PropertyName = "url")]
        Uri Url { get; set; }
        
        [JsonProperty(PropertyName = "comment_count")]
        int CommentCount { get; set; }
        
        [JsonProperty(PropertyName = "date")]
        DateTime Date { get; set; }

        [JsonProperty(PropertyName = "author")]
        string Author { get; set; }

        [JsonProperty(PropertyName = "author_group")]
        UserType AuthorGroup { get; set; }

        [JsonProperty(PropertyName = "author_avatar")]
        Uri AuthorAvatar { get; set; }

        [JsonProperty(PropertyName = "author_avatar_big")]
        Uri AuthorAvatarBig { get; set; }

        [JsonProperty(PropertyName = "author_avatar_med")]
        Uri AuthorAvatarMed { get; set; }

        [JsonProperty(PropertyName = "author_avatar_lo")]
        Uri AuthorAvatarLo { get; set; }

        [JsonProperty(PropertyName = "author_sex")]
        string AuthorSex { get; set; }

        /// <summary>
        /// Be careful!!! In one repository it's type of content, eg. video, image etc.
        /// in another it's type of data, eg. Link, Entry
        /// !? :( it's really confusing
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        string Type { get; set; }

        [JsonProperty(PropertyName = "vote_count")]
        int VoteCount { get; set; }

        [JsonConverter(typeof (DigStatusConverter))]
        [JsonProperty(PropertyName = "user_vote")]
        DigStatus UserVote { get; set; }

        [JsonProperty(PropertyName = "user_favorite")]
        bool UserFavorite { get; set; }
        
        [JsonProperty(PropertyName = "violation_url")]
        Uri ViolationUrl { get; set; }
        
        [JsonProperty(PropertyName = "app")]
        string App { get; set; }
    }
    
    public class WykopItemArrayTypeConverter : JsonConverter
    {
        internal class WykopItemType
        {
            [JsonProperty(PropertyName = "type")]
            [JsonConverter(typeof(WykopTypeConverter))]
            public WykopType Type { get; set; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JArray untypedArray = JArray.Load(reader);
            List<IWykopItem> resultItems = new List<IWykopItem>();

            foreach (var untypedObject in untypedArray)
            {
                WykopItemType whichTypeObject = (WykopItemType) JsonConvert.DeserializeObject(untypedObject.ToString(), typeof(WykopItemType));
                try
                {
                    switch (whichTypeObject?.Type)
                    {
                        case WykopType.Entry:
                            Entry entry =
                                (Entry) JsonConvert.DeserializeObject(untypedObject.ToString(), typeof (Entry));
                            resultItems.Add(entry);
                            break;
                        case WykopType.Link:
                            Link link = (Link) JsonConvert.DeserializeObject(untypedObject.ToString(), typeof (Link));
                            resultItems.Add(link);
                            break;
                    }
                }
                catch (System.Exception ex)
                {
                    // unknown data?
                }
            }

            return resultItems;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof (List<IWykopItem>);
        }
    }
}