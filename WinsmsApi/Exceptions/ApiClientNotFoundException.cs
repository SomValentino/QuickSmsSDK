using System;

namespace WinsmsApi.Exceptions
{
    public class ApiClientNotFoundException : Exception
    {
        public ApiClientNotFoundException(string message) : base(message)
        {
        }

        public ApiClientNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}