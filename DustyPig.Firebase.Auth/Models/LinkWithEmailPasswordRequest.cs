namespace DustyPig.Firebase.Auth.Models
{
    class LinkWithEmailPasswordRequest
    {
        public string IdToken { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool ReturnSecureToken => true;
    }
}
