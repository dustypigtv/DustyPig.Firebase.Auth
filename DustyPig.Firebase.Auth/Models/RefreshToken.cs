using System.Text.Json.Serialization;

namespace DustyPig.Firebase.Auth.Models
{
    public class RefreshToken
    {
        /// <summary>
        /// The number of seconds in which the ID token expires.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// The type of the refresh token, always "Bearer".
        /// </summary>
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// The Firebase Auth refresh token provided in the request or a new refresh token.
        /// </summary>
        public string Refresh_Token { get; set; }

        /// <summary>
        /// A Firebase Auth ID token.
        /// </summary>
        [JsonPropertyName("id_token")]
        public string IdToken { get; set; }

        /// <summary>
        /// The uid corresponding to the provided ID token.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Your Firebase project ID.
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }
    }
}
