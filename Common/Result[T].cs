namespace Common
{
    public class Result<T> : Result
    {
        public T Value { get; set; }

        protected internal Result(T value, bool success, string error)
            : base(success, error)
        {
            Value = value;
        }

        public static Result<T> Ok<T>(T value)
        {
            return new Result<T>(value, true, string.Empty);
        }

        public static Result<T> Fail<T>(string message)

        {

            return new Result<T>(default(T), false, message);

        }
    }
}