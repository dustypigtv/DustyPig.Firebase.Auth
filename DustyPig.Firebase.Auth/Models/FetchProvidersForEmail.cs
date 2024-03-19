using System.Collections.Generic;

namespace DustyPig.Firebase.Auth.Models;

public class FetchProvidersForEmail
{
    /// <summary>
    /// The list of providers that the user has previously signed in with.
    /// </summary>
    public List<string> AllProviders { get; set; } = [];

    /// <summary>
    /// Whether the email is for an existing account
    /// </summary>
    public bool Registered { get; set; }
}
