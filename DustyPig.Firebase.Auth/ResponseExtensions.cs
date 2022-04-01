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
                try { return JsonConvert.DeserializeObject<ErrorDataWrapper>(response.Error.Message).Data; }
                catch { }
            return null;
        }
    }
}