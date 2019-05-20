using RestSharp;

namespace WinsmsApi.Client.Interfaces
{
    public interface IApiClientInterceptor
    {
        /// <summary>
        /// Builds the request before it is been executed. Adding headers, queryparams etc.
        /// </summary>
        /// <param name="path">web api url path</param>
        /// <param name="method">Http method e.g GET or POST</param>
        /// <param name="postBody">Serialized data to posted to url</param>
        /// <param name="contentType">format of data to be posted. Default is json</param>
        /// <param name="configuration">Api configuration including username and password, header information e.t.c</param>
        /// <returns></returns>
        IRestRequest BuildRequest(string path, Method method, string postBody, string contentType,
            IConfiguration configuration);
        /// <summary>
        /// Intercept request before it being executed
        /// </summary>
        /// <param name="request"></param>
        void InterceptRequest(IRestRequest request);
        /// <summary>
        /// Intercept Response after request has been executed
        /// </summary>
        /// <param name="request">api request</param>
        /// <param name="response">api response</param>
        void InterceptResponse(IRestRequest request, IRestResponse response);
    }
}