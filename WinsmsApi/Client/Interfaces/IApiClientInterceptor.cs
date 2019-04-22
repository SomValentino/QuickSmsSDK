using RestSharp;

namespace WinsmsApi.Client.Interfaces
{
    public interface IApiClientInterceptor
    {
        IRestRequest BuildRequest(string path, Method method, string postBody, string contentType,
            IConfiguration configuration);
        
        void InterceptRequest(IRestRequest request);

        void InterceptResponse(IRestRequest request, IRestResponse response);
    }
}