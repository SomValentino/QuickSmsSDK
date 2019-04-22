using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using WinsmsApi.Client;
using WinsmsApi.Client.Interfaces;
using WinsmsApi.Manager.Interfaces;
using WinsmsApi.Models.Request.Sms.Send;
using WinsmsApi.Models.Response.Credit.Balance;
using WinsmsApi.Models.Response.Sms.Send;
using WinsmsApi.Models.Response.Sms.Status;

namespace WinsmsApi.Manager
{
    public class ApiSmsManager : IApiSmsManager
    {
        public ApiSmsManager(IApiClient apiClient)
        {
            ApiClient = apiClient;
        }
        public IApiClient ApiClient { get; set; }
        public async Task<ApiResponse<CreditBalanceResponse>> GetCreditBalance(string path)
        {
            var response = await ApiClient.CallApiAsync<CreditBalanceResponse,object>(path, Method.GET);
            return response;
        }

        public async Task<ApiResponse<SmsMessageResponse>> SendSms(SmsMessage message,string path)
        {
            var response = await ApiClient.CallApiAsync<SmsMessageResponse, SmsMessage>(path, Method.POST, message);
            return response;
        }

        public async Task<ApiResponse<MessageStatusResponse>> GetSmsStatus(List<int?> messageStatusRequest,string path)
        {
            var response =
                await ApiClient.CallApiAsync<MessageStatusResponse, List<int?>>(path, Method.POST,
                    messageStatusRequest);
            return response;
        }
    }
}