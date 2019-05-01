using System;

namespace WeatherApp.Services.Abstract
{
    public interface ILogger
    {
        void LogError(Exception exception);
        void LogMessage(string text);
    }
}
