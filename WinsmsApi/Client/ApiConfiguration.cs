using System.Collections.Generic;
using WinsmsApi.Client.Interfaces;

namespace WinsmsApi.Client
{
    public class ApiConfiguration : IConfiguration
    {
        public ApiConfiguration(): this("https://www.winsms.co.za/api/rest/v1")
        {
            
        }
        public ApiConfiguration(string baseUrlPath)
        {
            this.baseUrlPath = baseUrlPath;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public Dictionary<string, string> HeaderParams { get; set; }
        public Dictionary<string, string> QueryParams { get; set; }
        public Dictionary<string, string> UrlParams { get; set; }
        public string baseUrlPath { get; set; }
    }
}