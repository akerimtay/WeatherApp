using System.Net;
using WeatherApp.Services.Abstract;

namespace WeatherApp.Services
{
    public class Downloader : IDownloader
    {
        private readonly ILogger logger;

        public Downloader(ILogger logger)
        {
            this.logger = logger;
        }

        public string DownloadRawJsonData(string url)
        {
            using (var client = new WebClient())
            {
                try
                {
                    logger.LogMessage($"Запрос {url}");
                    return client.DownloadString(url);
                }
                catch (WebException exception)
                {
                    logger.LogError(exception);
                    return "";
                }
            }
        }
    }
}