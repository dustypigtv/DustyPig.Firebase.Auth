using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class OOBRequest
    {
        [JsonProperty("oobCode")]
        public string OOBCode { get; set; }
    }
}
