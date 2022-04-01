using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class SendPasswordResetEmailRequest
    {
        [JsonProperty("requestType")]
        public string RequestType => "PASSWORD_RESET";

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
