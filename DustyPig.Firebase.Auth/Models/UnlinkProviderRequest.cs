using Newtonsoft.Json;
using System.Collections.Generic;

namespace DustyPig.Firebase.Auth.Models
{
    class UnlinkProviderRequest
    {
        [JsonProperty("idToken")]
        public string IdToken { get; set; }

        [JsonProperty("deleteProvider")]
        public List<string> DeleteProvider { get; set; } = new List<string>();
    }
}
