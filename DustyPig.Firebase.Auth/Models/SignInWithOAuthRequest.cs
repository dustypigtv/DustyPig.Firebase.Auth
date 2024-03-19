namespace DustyPig.Firebase.Auth.Models;

class SignInWithOAuthRequest
{
    public string RequestUri { get; set; }

    public string PostBody { get; set; }

    public bool ReturnSecureToken => true;

    public bool ReturnIdpCredential { get; set; }
}
