
namespace apply_job_web_api.Commons.Responses
{
    public enum ResponseStatus
    {
        Success = 200,
        Error = 400
    }

    public sealed class Response<T>
    {
        public ResponseStatus Status { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }

        private Response(ResponseStatus status, string message, T data)
        {
            Status = status;
            Message = message;
            Data = data;
        }

        public static Response<T> Success(T data, string message) 
            => new Response<T> (ResponseStatus.Success, message, data);

        public static Response<T> Error(string message)
            => new Response<T>(ResponseStatus.Error, message, default);
    }
}
