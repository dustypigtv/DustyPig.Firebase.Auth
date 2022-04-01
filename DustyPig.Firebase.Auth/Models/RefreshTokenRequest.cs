using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth.Models
{
    class RefreshTokenRequest
    {
        [JsonProperty("grant_type")]
        public string GrantType => "refresh_token";

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
