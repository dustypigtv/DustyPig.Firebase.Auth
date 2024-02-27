using System.Collections.Generic;

namespace DustyPig.Firebase.Auth.Models
{
    public class User
    {
        /// <summary>
        /// The uid of the current user.
        /// </summary>
        public string LocalId { get; set; }

        /// <summary>
        /// The email of the account.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Whether or not the account's email has been verified.
        /// </summary>
        public bool EmailVerified { get; set; }

        /// <summary>
        /// The display name for the account.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// List of all linked provider objects which contain "providerId" and "federatedId".
        /// </summary>
        public List<ProviderUserInfo> ProviderUserInfo { get; set; } = [];

        /// <summary>
        /// The photo Url for the account.
        /// </summary>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// Hash version of password.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// The timestamp, in milliseconds, that the account password was last changed.
        /// </summary>
        public double PasswordUpdatedAt { get; set; }

        /// <summary>
        /// The timestamp, in seconds, which marks a boundary, before which Firebase ID token are considered revoked.
        /// </summary>
        public string ValidSince { get; set; }

        /// <summary>
        /// Whether the account is disabled or not.
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// The timestamp, in milliseconds, that the account last logged in at.
        /// </summary>
        public string LastLoginAt { get; set; }

        /// <summary>
        /// The timestamp, in milliseconds, that the account was created at.
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Whether the account is authenticated by the developer.
        /// </summary>
        public bool CustomAuth { get; set; }
    }
}