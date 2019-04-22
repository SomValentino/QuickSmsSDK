namespace WinsmsApi.Models.Response.Sms.Send
{
    public class MessageRecipientResponse
    {
        public string ClientMessageId { get; set; }
        public string MobileNumber { get; set; }
        public bool? Accepted { get; set; }
        public string AcceptError { get; set; }
        public int? ApiMessageId { get; set; }
        public int? ScheduledTime { get; set; }
        public double? CreditCost { get; set; }
        public double? NewCreditBalance { get; set; }
    }
}