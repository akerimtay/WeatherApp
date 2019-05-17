using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApp.DTO
{
    public class Forecast
    {
        [JsonProperty("forecastday")]
        public IList<Forecastday> ForecastDays { get; set; }
    }
}