using System.Linq;
using RestSharp;
using WinsmsApi.Client.Interfaces;

namespace WinsmsApi.Client
{
    public class ApiClientInterceptor : IApiClientInterceptor
    {
        public IRestRequest BuildRequest(string path, Method method, string postBody, string contentType,IConfiguration configurations)
        {
            var request = new RestRequest(path,method);

            if (configurations.HeaderParams != null && configurations.HeaderParams.Any())
            {
                foreach (var configuration in configurations.HeaderParams)
                {
                    request.AddHeader(configuration.Key, configuration.Value);
                }
            }

            if (configurations.QueryParams != null && configurations.QueryParams.Any())
            {
                foreach (var queryParam in configurations.QueryParams)
                {
                    request.AddQueryParameter(queryParam.Key, queryParam.Value);
                }
            }

            if (configurations.UrlParams != null && configurations.UrlParams.Any())
            {
                foreach (var urlParam in configurations.UrlParams)
                {
                    request.AddParameter(urlParam.Key, urlParam.Value, ParameterType.UrlSegment);
                }
            }

            if (postBody != null)
            {
                request.AddParameter(contentType,postBody,ParameterType.RequestBody);
            }

            return request;
        }

        public void InterceptRequest(IRestRequest request)
        {
            
        }

        public void InterceptResponse(IRestRequest request, IRestResponse response)
        {
            
        }
    }
}