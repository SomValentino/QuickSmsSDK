using System;
using RestSharp;

namespace WinsmsApi.Client.Interfaces
{
    public interface IClientDataConverter
    {
        T DeserializeResponse<T>(IRestResponse response);
        string Serialize<T>(T request);
    }
}