using System.Collections.Generic;
using System.Net;

namespace WinsmsApi.Client
{
    public class ApiResponse<T> where T: class
    {
        public ApiResponse(HttpStatusCode statusCode, Dictionary<string, string> headers, T data)
        {
            StatusCode = statusCode;
            Headers = headers;
            Data = data;
        }
        public HttpStatusCode StatusCode { get; }
        public Dictionary<string,string> Headers { get; }
        public T Data { get; }
        
    }
}