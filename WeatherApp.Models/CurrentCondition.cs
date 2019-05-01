using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApp.Models
{
    public class CurrentCondition
    {
        [JsonProperty("temp_C")]
        public int TempC { get; set; }

        [JsonProperty("weatherIconUrl")]
        public List<WeatherIconUrl> WeatherIconUrl { get; set; }

        [JsonProperty("windspeedKmph")]
        public int WindSpeedKmph { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("FeelsLikeC")]
        public int FeelsLikeC { get; set; }
    }
}