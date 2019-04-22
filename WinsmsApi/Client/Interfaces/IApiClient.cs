using System.Threading.Tasks;
using RestSharp;

namespace WinsmsApi.Client.Interfaces
{
    public interface IApiClient
    {
        ApiResponse<TData> CallApi<TData, TParam>(string path, Method method, TParam Data = null,
            string contentType = "application/json") where TParam : class where TData : class;

        Task<ApiResponse<TData>> CallApiAsync<TData, TParam>(string path, Method method, TParam Data = null,
            string contentType = "application/json") where TParam : class where TData : class;
    }
}