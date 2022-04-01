using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class EmailPasswordRequest
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("returnSecureToken")]
        public bool ReturnSecureToken => true;
    }
}
