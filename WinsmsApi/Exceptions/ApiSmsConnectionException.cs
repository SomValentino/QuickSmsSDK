using System;

namespace WinsmsApi.Exceptions
{
    public class ApiSmsConnectionException : Exception
    {
        public ApiSmsConnectionException(string message) : base(message)
        {
        }

        public ApiSmsConnectionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}