namespace DustyPig.Firebase.Auth.Models
{
    public class SignInWithOAuth
    {
        /// <summary>
        /// The unique ID identifies the IdP account.
        /// </summary>
        public string FederatedId { get; set; }

        /// <summary>
        /// The linked provider ID (e.g. "google.com" for the Google provider).
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// The uid of the authenticated user.
        /// </summary>
        public string LocalId { get; set; }

        /// <summary>
        /// Whether the sign-in email is verified.
        /// </summary>
        public bool EmailVerified { get; set; }

        /// <summary>
        /// The email of the account.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The OIDC id token if available.
        /// </summary>
        public string OAuthIdToken { get; set; }

        /// <summary>
        /// The OAuth access token if available.
        /// </summary>
        public string OAuthAccessToken { get; set; }

        /// <summary>
        /// The OAuth 1.0 token secret if available.
        /// </summary>
        public string OAuthTokenSecret { get; set; }

        /// <summary>
        /// The stringified JSON response containing all the IdP data corresponding to the provided OAuth credential.
        /// </summary>
        public string RawUserInfo { get; set; }

        /// <summary>
        /// The first name for the account.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name for the account.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The full name for the account.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The display name for the account.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The photo Url for the account.
        /// </summary>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// A Firebase Auth ID token for the authenticated user.
        /// </summary>
        public string IdToken { get; set; }

        /// <summary>
        /// A Firebase Auth refresh token for the authenticated user.
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// The number of seconds in which the ID token expires.
        /// </summary>
        public string ExpiresIn { get; set; }

        /// <summary>
        /// Whether another account with the same credential already exists. The user will need to sign in to the original account and then link the current credential to it.
        /// </summary>
        public bool NeedConfirmation { get; set; }
    }
}
