using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class ErrorDataWrapper
    {
        [JsonProperty("error")]
        public ErrorData Data { get; set; }
    }
}
