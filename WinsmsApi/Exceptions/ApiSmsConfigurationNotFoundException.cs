using System;

namespace WinsmsApi.Exceptions
{
    public class ApiSmsConfigurationNotFoundException : Exception
    {
        public ApiSmsConfigurationNotFoundException(string message) : base(message)
        {
        }

        public ApiSmsConfigurationNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}