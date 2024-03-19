using System.Text.Json.Serialization;

namespace DustyPig.Firebase.Auth.Models;

class RefreshTokenRequest
{
    [JsonPropertyName("grant_type")]
    public string GrantType => "refresh_token";

    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; }
}
