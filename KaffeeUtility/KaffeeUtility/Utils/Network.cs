using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace KaffeeUtility.Utils
{
    internal class Network
    {
        public static async Task<string> GetString(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
        }

        public static bool IsUrl(string url)
        {
            if (string.IsNullOrEmpty(url)) return false;
            if (string.IsNullOrWhiteSpace(url)) return false;

            if (url.StartsWith("http"))
                return true;
            else
                return false;
        }

        public static async Task DownloadFile(string url, string filePath)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await stream.CopyToAsync(fileStream);
                }
            }
        }
    }
}
