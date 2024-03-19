namespace DustyPig.Firebase.Auth.Models;

class SendPasswordResetEmailRequest
{
    public string RequestType => "PASSWORD_RESET";

    public string Email { get; set; }
}
