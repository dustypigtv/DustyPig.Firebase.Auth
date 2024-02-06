using System.Text.Json.Serialization;

namespace DustyPig.Firebase.Auth.Models
{
    class ConfirmPasswordResetRequest
    {
        [JsonPropertyName("oobCode")]
        public string OOBCode { get; set; }

        public string NewPassword { get; set; }
    }
}
