using System;

namespace DustyPig.Firebase.Auth.Tests
{
    static class TestEnvironment
    {
        public static string GetFirebaseAPIKey() => GetVariable("FIREBASE_API_KEY");

        public static string GetTestPassword() => GetVariable("TEST_PASSWORD");

        private static string GetVariable(string varName)
        {
            string ret = Environment.GetEnvironmentVariable(varName, EnvironmentVariableTarget.Process);

            if (string.IsNullOrWhiteSpace(ret))
                ret = Environment.GetEnvironmentVariable(varName, EnvironmentVariableTarget.User);

            if (string.IsNullOrWhiteSpace(ret))
                ret = Environment.GetEnvironmentVariable(varName, EnvironmentVariableTarget.Machine);

            return ret;
        }
    }
}
