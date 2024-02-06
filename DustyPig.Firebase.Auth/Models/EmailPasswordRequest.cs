namespace DustyPig.Firebase.Auth.Models
{
    class EmailPasswordRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool ReturnSecureToken => true;
    }
}
