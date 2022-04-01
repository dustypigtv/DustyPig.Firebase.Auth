using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class FetchProvidersForEmailRequest
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("continueUri")]
        public string ContinueUri { get; set; }
    }
}
