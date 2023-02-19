namespace API.Infrastructure.Core
{
    public class Result
    {
        public Result(int statusCode)
        {
            StatusCode = statusCode;
        }

        public Result(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public Result(int statusCode, object value)
        {
            StatusCode = statusCode;
            Value = value;
        }

        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public object? Value { get; set; }
    }
}
