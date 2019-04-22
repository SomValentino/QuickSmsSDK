namespace WinsmsApi.Models.Request.Sms.Status
{
    public class MessageStatus
    {
        public int? ApiMessageId { get; set; }
        public string MobileNumber { get; set; }
        public bool? StatusDelivered { get; set; }
        public string StatusErrorCode { get; set; }
        public int? StatusTime { get; set; }
        public double? CreditCost { get; set; }
    }
}