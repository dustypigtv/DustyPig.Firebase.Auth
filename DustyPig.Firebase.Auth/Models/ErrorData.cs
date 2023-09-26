using System;
using System.Collections.Generic;

namespace DustyPig.Firebase.Auth.Models
{
    public class ErrorData
    {
        public List<Error> Errors { get; set; } = new List<Error>();

        public int Code { get; set; }

        public string Message { get; set; }
    }
}
