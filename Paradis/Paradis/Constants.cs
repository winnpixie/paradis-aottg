using System;
using System.IO;
using System.Net.Http;

namespace Paradis
{
    internal class Constants
    {
        public static readonly string AppVersion = "1.2";
        public static readonly string WorkingDirectory = Environment.CurrentDirectory;
        public static readonly string InstallDirectory = Path.Combine(WorkingDirectory, "Client");
        public static readonly int PlatformArch = Environment.Is64BitOperatingSystem ? 64 : 32;

        public static readonly string BaseUrl = "https://aottg.winnpixie.com/clients/guardian";
        public static readonly string VersionUrl = BaseUrl + "/version.txt";
        public static readonly string BinaryName = "Guardian_Win" + PlatformArch + ".zip";
        public static readonly string BinaryUrl = BaseUrl + "/" + BinaryName;

        public static readonly Lazy<HttpClient> HttpClient = new Lazy<HttpClient>(() =>
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(ushort.MaxValue);
            return client;
        });
    }
}
