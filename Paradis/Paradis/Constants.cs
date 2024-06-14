using System;
using System.Net.Http;

namespace Paradis
{
    internal class Constants
    {
        public static readonly string AppVersion = "1.1.0";
        public static readonly string InstallDir = Environment.CurrentDirectory;
        public static readonly int OSArch = Environment.Is64BitOperatingSystem ? 64 : 32;

        public static readonly string BaseUrl = "https://aottgfan.site/clients/guardian";
        public static readonly string VersionUrl = BaseUrl + "/version.txt";
        public static readonly string BinaryName = "Guardian_Win" + OSArch + ".zip";
        public static readonly string BinaryUrl = BaseUrl + "/" + BinaryName;

        public static readonly Lazy<HttpClient> Web = new Lazy<HttpClient>(() =>
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(int.MaxValue);
            return client;
        });
    }
}
