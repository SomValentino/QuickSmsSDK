using System.Collections.Generic;

namespace WinsmsApi.Models.Request.Sms.Send
{
    public class SmsMessage
    {
        public string Message { get; set; }
        public List<MessageRecipient> Recipients { get; set; }
        public int? ScheduledTime { get; set; }
        public int? MaxSegments { get; set; }
    }
}