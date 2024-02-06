using System.Text.Json.Serialization;

namespace DustyPig.Firebase.Auth.Models
{
    class OOBRequest
    {
        [JsonPropertyName("oobCode")]
        public string OOBCode { get; set; }
    }
}
