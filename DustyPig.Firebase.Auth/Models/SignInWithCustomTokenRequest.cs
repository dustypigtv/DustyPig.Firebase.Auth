namespace DustyPig.Firebase.Auth.Models;

class SignInWithCustomTokenRequest
{
    public string Token { get; set; }

    public bool ReturnSecureToken => true;
}
