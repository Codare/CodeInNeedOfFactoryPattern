using System;

namespace Common
{
    public class Result
    {
        public bool Success { get; }

        public string Error { get; }

        public bool Failure => !Success;

        protected Result(bool success, string error)
        {
            Success = success;
            Error = error;
        }

        public static Result Fail(string message)
        {
            return new Result(false, message);
        }

        
    }
}
