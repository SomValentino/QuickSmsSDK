using System;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using WinsmsApi.Client.Interfaces;
using WinsmsApi.Models.Response.Sms.Status;

namespace WinsmsApi.Client
{
    public class ApiClient : IApiClient
    {
        private readonly IConfiguration _configurations;
        private readonly IClientDataConverter _clientDataConverter;
        private readonly IApiClientInterceptor _apiClientInterceptor;
        private RestClient RestClient { get; }

        protected ApiClient(IConfiguration configuration, IClientDataConverter clientDataConverter,
            IApiClientInterceptor requestBuilder)
        {
            _configurations = configuration;
            _clientDataConverter = clientDataConverter;
            _apiClientInterceptor = requestBuilder;
            RestClient = new RestClient(_configurations.baseUrlPath);
        }

        public ApiResponse<TData> CallApi<TData, TParam>(string path, Method method, TParam Data = null,
            string contentType = "application/json") where TParam : class where TData : class
        {
            try
            {
                var request = PreRestRequest<TData, TParam>(path, method, Data, contentType);
                var response = RestClient.Execute(request);
                var data = PostRestResponse<TData, TParam>(request, response);
                var headers = data.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());
                var rawdata = _clientDataConverter.DeserializeResponse<TData>(data);
                return new ApiResponse<TData>(data.StatusCode,headers,rawdata);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public async Task<ApiResponse<TData>> CallApiAsync<TData,TParam>(string path, Method method, TParam Data = null,
            string contentType = "application/json") where TParam : class where TData: class
        {
            try
            {
                var request = PreRestRequest<TData, TParam>(path, method, Data, contentType);
                var response = await RestClient.ExecuteTaskAsync(request);
                var data = PostRestResponse<TData, TParam>(request, response);
                var headers = data.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());
                var rawdata = _clientDataConverter.DeserializeResponse<TData>(data);
                return new ApiResponse<TData>(data.StatusCode,headers,rawdata);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        private IRestResponse PostRestResponse<TData, TParam>(IRestRequest request, IRestResponse response) where TParam : class
        {
            _apiClientInterceptor.InterceptResponse(request, response);
            return response;
        }

        private IRestRequest PreRestRequest<TData, TParam>(string path, Method method, TParam Data, string contentType)
            where TParam : class
        {
            string postBody = null;
            if (Data != null)
            {
                postBody = _clientDataConverter.Serialize(Data);
            }

            var request = _apiClientInterceptor.BuildRequest(path, method, postBody, contentType,_configurations);
            _apiClientInterceptor.InterceptRequest(request);
            return request;
        }
    }
}