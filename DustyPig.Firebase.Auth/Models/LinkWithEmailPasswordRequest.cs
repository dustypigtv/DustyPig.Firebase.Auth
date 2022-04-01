using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class LinkWithEmailPasswordRequest
    {
        [JsonProperty("idToken")]
        public string IdToken { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("returnSecureToken")]
        public bool ReturnSecureToken => true;
    }
}
