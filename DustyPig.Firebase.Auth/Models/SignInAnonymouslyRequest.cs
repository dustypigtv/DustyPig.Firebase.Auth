using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class SignInAnonymouslyRequest
    {
        [JsonProperty("returnSecureToken")]
        public bool ReturnSecureToken => true;
    }
}
