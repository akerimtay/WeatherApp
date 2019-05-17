using System;
using System.Net;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class Downloader
    {
        public async Task<string> DownloadRawJsonDataAsync(string url)
        {
            using (var client = new WebClient())
            {
                client.Encoding = System.Text.Encoding.UTF8;

                try
                {
                    return await client.DownloadStringTaskAsync(url);
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }
    }
}