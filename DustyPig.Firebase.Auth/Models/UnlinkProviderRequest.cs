using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.Firebase.Auth.Models;

class UnlinkProviderRequest
{
    public string IdToken { get; set; }

    [JsonPropertyName("deleteProvider")]
    public List<string> DeleteProviders { get; set; } = [];
}
