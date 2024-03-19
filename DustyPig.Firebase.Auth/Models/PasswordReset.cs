namespace DustyPig.Firebase.Auth.Models;

public class PasswordReset
{
    /// <summary>
    /// User's email address.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Type of the email action code. Should be "PASSWORD_RESET".
    /// </summary>
    public string RequestType { get; set; }
}
