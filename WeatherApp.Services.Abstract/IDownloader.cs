namespace WeatherApp.Services.Abstract
{
    public interface IDownloader
    {
        string DownloadRawJsonData(string url);
    }
}
