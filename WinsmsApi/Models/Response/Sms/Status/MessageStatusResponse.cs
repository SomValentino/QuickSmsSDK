using System;
using System.Collections.Generic;
using WinsmsApi.Models.Request.Sms.Status;

namespace WinsmsApi.Models.Response.Sms.Status
{
    public class MessageStatusResponse
    {
        public int? StatusCode { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Version { get; set; }
        public List<MessageStatus> MessageStatuses { get; set; }
    }
}