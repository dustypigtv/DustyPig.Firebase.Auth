using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class ChangePasswordRequest
    {
        [JsonProperty("idToken")]
        public string IdToken { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("returnSecureToken")]
        public bool returnSecureToken { get; set; }

    }
}
