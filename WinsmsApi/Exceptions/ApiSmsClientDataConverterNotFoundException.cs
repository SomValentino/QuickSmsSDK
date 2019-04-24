using System;

namespace WinsmsApi.Exceptions
{
    public class ApiSmsClientDataConverterNotFoundException : Exception
    {
        public ApiSmsClientDataConverterNotFoundException(string message) : base(message)
        {
        }

        public ApiSmsClientDataConverterNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}