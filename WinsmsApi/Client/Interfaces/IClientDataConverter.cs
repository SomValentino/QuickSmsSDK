using System;
using RestSharp;

namespace WinsmsApi.Client.Interfaces
{
    public interface IClientDataConverter
    {
        /// <summary>
        /// Desserialize response from api to class object
        /// </summary>
        /// <param name="response">api response</param>
        /// <typeparam name="T">Type of class object</typeparam>
        /// <returns>T</returns>
        T DeserializeResponse<T>(IRestResponse response);
        /// <summary>
        /// Serialize data to be posted to api to json string
        /// </summary>
        /// <param name="request">api request</param>
        /// <typeparam name="T">Type of data to be posted</typeparam>
        /// <returns>string</returns>
        string Serialize<T>(T request);
    }
}