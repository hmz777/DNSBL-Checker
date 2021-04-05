using DnsClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace DNSBLChecker.Checker
{
    public static class IPChecker
    {
        private static LookupClient LookupClient { get; set; } = new LookupClient() { UseCache = true };
        private static List<string> DNSBLUrls { get; set; } = new List<string>();

        public async static IAsyncEnumerable<KeyValuePair<string, string>> CheckIPAsync(string IP, [EnumeratorCancellation] CancellationToken CancellationToken = default)
        {
            foreach (var Url in DNSBLUrls)
            {
                CancellationToken.ThrowIfCancellationRequested();

                KeyValuePair<string, string> Result;

                try
                {
                    Result = new KeyValuePair<string, string>(Url, (await LookupClient
                        .QueryAsync(IP + "." + Url, QueryType.A, cancellationToken: new CancellationTokenSource(TimeSpan.FromSeconds(5)).Token))
                        .Answers
                        .FirstOrDefault()?.ToString() ?? "x");
                }
                catch (Exception)
                {
                    continue;
                }

                yield return Result;
            }
        }

        public async static Task<int> LoadUrlsAsync(string Path)
        {
            DNSBLUrls.Clear();

            var Urls = await File.ReadAllTextAsync(Path);

            foreach (var Url in Urls.Split("\n"))
            {
                DNSBLUrls.Add(Url.Trim());
            }

            return DNSBLUrls.Count;
        }

        public static bool AreUrlsLoaded()
        {
            return DNSBLUrls.Count > 0;
        }
    }
}
