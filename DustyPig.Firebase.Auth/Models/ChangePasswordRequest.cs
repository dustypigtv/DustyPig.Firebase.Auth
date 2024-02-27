namespace DustyPig.Firebase.Auth.Models
{
    class ChangePasswordRequest
    {
        public string IdToken { get; set; }

        public string Password { get; set; }

        public bool ReturnSecureToken { get; set; }

    }
}
