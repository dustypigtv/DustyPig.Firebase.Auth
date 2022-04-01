using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class IdTokenRequest
    {
        [JsonProperty("idToken")]
        public string IdToken { get; set; }
    }
}
