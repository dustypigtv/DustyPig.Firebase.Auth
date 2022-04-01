using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class ChangeEmailRequest
    {
        [JsonProperty("idToken")]
        public string IdToken { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("returnSecureToken")]
        public bool ReturnSecureToken { get; set; }
    }
}
