using System.Collections.Generic;
using System.Threading.Tasks;
using WinsmsApi.Client;
using WinsmsApi.Client.Interfaces;
using WinsmsApi.Models.Request.Sms.Send;
using WinsmsApi.Models.Request.Sms.Status;
using WinsmsApi.Models.Response.Credit.Balance;
using WinsmsApi.Models.Response.Sms.Send;
using WinsmsApi.Models.Response.Sms.Status;

namespace WinsmsApi.Manager.Interfaces
{
    public interface IApiSmsManager
    {
        IApiClient ApiClient { get;}
        ApiResponse<CreditBalanceResponse> GetCreditBalance(string path);
        Task<ApiResponse<CreditBalanceResponse>> GetCreditBalanceAsync(string path);
        ApiResponse<SmsMessageResponse> SendSms(SmsMessage message,string path);
        Task<ApiResponse<SmsMessageResponse>> SendSmsAsync(SmsMessage message,string path);
        ApiResponse<MessageStatusResponse> GetSmsStatus(List<int?> messageStatusRequest, string path);
        Task<ApiResponse<MessageStatusResponse>> GetSmsStatusAsync(List<int?> messageStatusRequest, string path);
    }
}