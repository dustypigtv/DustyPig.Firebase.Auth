namespace DustyPig.Firebase.Auth.Models
{
    class ChangeEmailRequest
    {
        public string IdToken { get; set; }

        public string Email { get; set; }

        public bool ReturnSecureToken { get; set; }
    }
}
