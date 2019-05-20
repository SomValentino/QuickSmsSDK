using System.Threading.Tasks;
using RestSharp;

namespace WinsmsApi.Client.Interfaces
{
    public interface IApiClient
    {
        /// <summary>
        /// Synchronously call api to return an sms response from WinSms Api
        /// </summary>
        /// <param name="path">the web api path</param>
        /// <param name="method">Http method e.g GET, POST, PUT, DELETE</param>
        /// <param name="Data">Additional data to be sent if method is Post</param>
        /// <param name="contentType">Format of data to sent through to api. Default is json</param>
        /// <typeparam name="TData">Type of data to be returned</typeparam>
        /// <typeparam name="TParam">Type of data to be sent through</typeparam>
        /// <returns>ApiResponse of type TData</returns>
        ApiResponse<TData> CallApi<TData, TParam>(string path, Method method, TParam Data = null,
            string contentType = "application/json") where TParam : class where TData : class;
        /// <summary>
        /// Asynchronously call api to return an sms response from WinSms Api
        /// </summary>
        /// <param name="path">the web api path</param>
        /// <param name="method">Http method e.g GET, POST, PUT, DELETE</param>
        /// <param name="Data">Additional data to be sent if method is Post</param>
        /// <param name="contentType">Format of data to sent through to api. Default is json</param>
        /// <typeparam name="TData">Type of data to be returned</typeparam>
        /// <typeparam name="TParam">Type of data to be sent through</typeparam>
        /// <returns>ApiResponse of type TData</returns>
        Task<ApiResponse<TData>> CallApiAsync<TData, TParam>(string path, Method method, TParam Data = null,
            string contentType = "application/json") where TParam : class where TData : class;
    }
}