using Newtonsoft.Json;
using RestSharp;
using WinsmsApi.Client.Interfaces;

namespace WinsmsApi.Client
{
    public class ClientDataConverter : IClientDataConverter
    {
        public T DeserializeResponse<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public string Serialize<T>(T request)
        {
            return JsonConvert.SerializeObject(request);
        }
    }
}