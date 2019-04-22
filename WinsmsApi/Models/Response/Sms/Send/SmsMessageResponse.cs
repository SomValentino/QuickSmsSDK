using System;
using System.Collections.Generic;

namespace WinsmsApi.Models.Response.Sms.Send
{
    public class SmsMessageResponse
    {
        public int? StatusCode { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Version { get; set; }
        public List<MessageRecipientResponse> Recipients { get; set; }
    }
}