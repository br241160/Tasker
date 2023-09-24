namespace API.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public ApiResponse(int statusCode, string? message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "It's a bad request error",
                401 => "It's a authorization error",
                404 => "It's a resource not found error",
                500 => "It's a other error",
                _ => "Not sure what type of error ist that"
            };
        }
    }
}