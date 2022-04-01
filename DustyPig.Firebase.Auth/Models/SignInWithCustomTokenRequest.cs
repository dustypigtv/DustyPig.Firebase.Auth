using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class SignInWithCustomTokenRequest
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("returnSecureToken")]
        public bool ReturnSecureToken => true;
    }
}
