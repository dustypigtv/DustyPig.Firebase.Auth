using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class LinkWithOAuthRequest
    {
        [JsonProperty("idToken")]
        public string IdToken { get; set; }

        [JsonProperty("requestUri")]
        public string RequestUri { get; set; }

        [JsonProperty("postBody")]
        public string PostBody { get; set; }

        [JsonProperty("returnSecureToken")]
        public bool ReturnSecureToken => true;

        [JsonProperty("returnIdpCredential")]
        public bool ReturnIdpCredential { get; set; }
    }
}
