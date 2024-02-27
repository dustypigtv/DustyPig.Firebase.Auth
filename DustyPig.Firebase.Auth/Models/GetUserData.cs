using System.Collections.Generic;

namespace DustyPig.Firebase.Auth.Models
{
    public class GetUserData
    {
        /// <summary>
        /// The account associated with the given Firebase ID token.
        /// </summary>
        public List<User> Users { get; set; } = [];
    }
}
