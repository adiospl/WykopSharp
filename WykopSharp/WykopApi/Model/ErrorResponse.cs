using Newtonsoft.Json;

namespace WykopSharp.Model
{
    public class Error
    {

        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }

    public class ErrorResponse
    {

        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }

    }
}
