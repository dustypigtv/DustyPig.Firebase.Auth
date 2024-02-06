namespace DustyPig.Firebase.Auth.Models
{
    public class SignInWithCustomToken
    {
        /// <summary>
        /// A Firebase Auth ID token generated from the provided custom token.
        /// </summary>
        public string IdToken { get; set; }

        /// <summary>
        /// A Firebase Auth refresh token generated from the provided custom token.
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// The number of seconds in which the ID token expires.
        /// </summary>
        public string ExpiresIn { get; set; }
    }
}
