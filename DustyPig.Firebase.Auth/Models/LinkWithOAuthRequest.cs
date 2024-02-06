namespace DustyPig.Firebase.Auth.Models
{
    class LinkWithOAuthRequest
    {
        public string IdToken { get; set; }

        public string RequestUri { get; set; }

        public string PostBody { get; set; }

        public bool ReturnSecureToken => true;

        public bool ReturnIdpCredential { get; set; }
    }
}
