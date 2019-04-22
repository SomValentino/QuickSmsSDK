namespace WinsmsApi.Models.Request.Sms.Send
{
    public class MessageRecipient
    {
        public string MobileNumber { get; set; }
        public string ClientMessageId { get; set; }
        public string AcceptError { get; set; }
        public int? ApiMessageId { get; set; }
        public int? ScheduledTime { get; set; }
    }
}