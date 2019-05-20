using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using WinsmsApi.Client;
using WinsmsApi.Client.Interfaces;
using WinsmsApi.Exceptions;
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
            ApiClient = apiClient ?? throw new ApiClientNotFoundException("The api client object cannot null.");
        }
        public IApiClient ApiClient { get; }
        public ApiResponse<CreditBalanceResponse> GetCreditBalance(string path)
        {
            var response = ApiClient.CallApi<CreditBalanceResponse, object>(path, Method.GET);
            return response;
        }

        public async Task<ApiResponse<CreditBalanceResponse>> GetCreditBalanceAsync(string path)
        {
            var response = await ApiClient.CallApiAsync<CreditBalanceResponse,object>(path, Method.GET);
            return response;
        }

        public ApiResponse<SmsMessageResponse> SendSms(SmsMessage message, string path)
        {
            var response = ApiClient.CallApi<SmsMessageResponse, SmsMessage>(path, Method.POST, message);
            return response;
        }

        public async Task<ApiResponse<SmsMessageResponse>> SendSmsAsync(SmsMessage message,string path)
        {
            var response = await ApiClient.CallApiAsync<SmsMessageResponse, SmsMessage>(path, Method.POST, message);
            return response;
        }

        public ApiResponse<MessageStatusResponse> GetSmsStatus(List<int?> messageStatusRequest, string path)
        {
            var response =
                ApiClient.CallApi<MessageStatusResponse, List<int?>>(path, Method.POST, messageStatusRequest);
            return response;
        }

        public async Task<ApiResponse<MessageStatusResponse>> GetSmsStatusAsync(List<int?> messageStatusRequest,string path)
        {
            var response =
                await ApiClient.CallApiAsync<MessageStatusResponse, List<int?>>(path, Method.POST,
                    messageStatusRequest);
            return response;
        }
    }
}