using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DNSBLChecker.Helpers
{
    public static class Tools
    {
        public static HttpClient HttpClient = new HttpClient();

        public static string ReverseIP(string IP)
        {
            return string.Join('.', IP.Split('.').Reverse());
        }

        public static bool IsIPOk(string Result)
        {
            return Result == "x";
        }

        public async static Task<string> GetCurrentIPAsync()
        {
            return await HttpClient.GetStringAsync("https://api.ipify.org");
        }

        public static void Dispose()
        {
            HttpClient.Dispose();
        }
    }
}
