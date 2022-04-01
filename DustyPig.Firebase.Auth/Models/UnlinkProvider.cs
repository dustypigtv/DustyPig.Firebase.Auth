﻿using System.Collections.Generic;

namespace DustyPig.Firebase.Auth.Models
{
    public class UnlinkProvider
    {
        /// <summary>
        /// The uid of the current user.
        /// </summary>
        public string LocalId { get; set; }

        /// <summary>
        /// User's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// User's new display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// User's new photo url.
        /// </summary>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// Hash version of the password.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// List of all linked provider objects which contain "providerId" and "federatedId".
        /// </summary>        
        public List<ProviderUserInfo> ProviderUserInfo { get; set; } = new List<ProviderUserInfo>();

        /// <summary>
        /// Whether or not the account's email has been verified.
        /// </summary>
        public bool EmailVerified { get; set; }
    }
}
