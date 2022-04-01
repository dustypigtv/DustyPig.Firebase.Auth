using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class SendEmailVerificationRequest
    {
        [JsonProperty("requestType")]
        public string RequestType => "VERIFY_EMAIL";

        [JsonProperty("idToken")]
        public string IdToken { get; set; }
    }
}
