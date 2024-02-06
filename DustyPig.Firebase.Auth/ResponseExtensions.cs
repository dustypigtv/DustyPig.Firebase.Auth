using DustyPig.Firebase.Auth.Models;
using DustyPig.REST;
using System.Text.Json;

namespace DustyPig.Firebase.Auth
{
    public static class ResponseExtensions
    {
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new(JsonSerializerDefaults.Web);

        public static ErrorData FirebaseError(this Response response)
        {
            if (response != null && !response.Success)
                try { return JsonSerializer.Deserialize<ErrorDataWrapper>(response.RawContent, _jsonSerializerOptions).Data; }
                catch { }
            return null;
        }

        public static void ThrowIfFirebaseError(this Response response)
        {
            if (response != null && !response.Success)
            {
                ErrorData errorData = null;
                try { errorData = JsonSerializer.Deserialize<ErrorDataWrapper>(response.RawContent, _jsonSerializerOptions).Data; }
                catch { }

                if (errorData == null)
                    response.ThrowIfError();

                throw new System.Exception(errorData.Message);

            }
        }
    }
}