using System;

namespace WinsmsApi.Exceptions
{
    public class ApiSmsClientInterceptorNotFoundException : Exception
    {
        public ApiSmsClientInterceptorNotFoundException(string message) : base(message)
        {
        }

        public ApiSmsClientInterceptorNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}