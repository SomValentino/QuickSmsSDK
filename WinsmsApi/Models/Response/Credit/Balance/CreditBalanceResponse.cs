using System;

namespace WinsmsApi.Models.Response.Credit.Balance
{
    public class CreditBalanceResponse
    {
        public int? StatusCode { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Version { get; set; }
        public double? CreditBalance { get; set; }
    }
}