using DustyPig.Firebase.Auth.Models;
using DustyPig.REST;
using Newtonsoft.Json;

namespace DustyPig.Firebase.Auth
{
    public static class ResponseExtensions
    {
        public static ErrorData FirebaseError(this Response response)
        {
            if (response != null && !response.Success)
                try { return JsonConvert.DeserializeObject<ErrorDataWrapper>(response.RawContent).Data; }
                catch { }
            return null;
        }

        public static void ThrowIfFirebaseError(this Response response)
        {
            if (response != null && !response.Success)
            {
                ErrorData errorData = null;
                try { errorData = JsonConvert.DeserializeObject<ErrorDataWrapper>(response.RawContent).Data; }
                catch { }

                if (errorData == null)
                    response.ThrowIfError();

                throw new System.Exception(errorData.Message);

            }
        }
    }
}