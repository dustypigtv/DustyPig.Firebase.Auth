using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.Firebase.Auth.Models;

class UpdateProfileRequest
{
    public string IdToken { get; set; }

    public string DisplayName { get; set; }

    public string PhotoUrl { get; set; }

    [JsonPropertyName("deleteAttribute")]
    public List<string> DeleteAttributes { get; set; }

    public bool ReturnSecureToken { get; set; }
}
