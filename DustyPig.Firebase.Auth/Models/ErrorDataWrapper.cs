using System.Text.Json.Serialization;

namespace DustyPig.Firebase.Auth.Models
{
    class ErrorDataWrapper
    {
        [JsonPropertyName("error")]
        public ErrorData Data { get; set; }
    }
}
