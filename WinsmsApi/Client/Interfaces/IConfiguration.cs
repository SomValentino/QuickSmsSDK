using System.Collections.Generic;

namespace WinsmsApi.Client.Interfaces
{
    public interface IConfiguration
    {
        string Username { get; set; }
        string Password { get; set; }
        Dictionary<string,string> HeaderParams { get; set; }
        Dictionary<string,string> QueryParams { get; set; }
        Dictionary<string,string> UrlParams { get; set; }
        string baseUrlPath { get; set; }
    }
}