using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class ConfirmPasswordResetRequest
    {
        [JsonProperty("oobCode")]
        public string OOBCode { get; set; }

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }
    }
}
