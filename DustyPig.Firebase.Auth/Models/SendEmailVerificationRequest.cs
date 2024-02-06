namespace DustyPig.Firebase.Auth.Models
{
    class SendEmailVerificationRequest
    {
        public string RequestType => "VERIFY_EMAIL";

        public string IdToken { get; set; }
    }
}
