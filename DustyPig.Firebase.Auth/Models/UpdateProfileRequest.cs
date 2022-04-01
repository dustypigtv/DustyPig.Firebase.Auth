using Newtonsoft.Json;
using System.Collections.Generic;

namespace DustyPig.Firebase.Auth.Models
{
    class UpdateProfileRequest
    {
        [JsonProperty("idToken")]
        public string IdToken { get; set; }

        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        [JsonProperty("photoUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string PhotoUrl { get; set; }

        [JsonProperty("deleteAttribute", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeleteAttributes { get; set; }

        [JsonProperty("returnSecureToken")]
        public bool ReturnSecureToken { get; set; }
    }
}
