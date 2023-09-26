using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DustyPig.Firebase.Auth.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public async Task BasicAccountOps()
        {
            var client = new Client(TestEnvironment.GetFirebaseAPIKey());

            var tokenResponse = await client.SignInWithEmailPasswordAsync("testuser@dustypig.tv", "test password");
            tokenResponse.ThrowIfError();

            var refreshResponse = await client.RefreshTokenAsync(tokenResponse.Data.RefreshToken);
            refreshResponse.ThrowIfError();

            var updateResponse = await client.UpdateProfileAsync(refreshResponse.Data.IdToken, "Test User", null);
            updateResponse.ThrowIfError();
        }
    }
}
