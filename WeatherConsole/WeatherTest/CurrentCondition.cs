using System.Collections.Generic;

namespace WeatherTest
{
    public class CurrentCondition
    {
        [JsonProperty("observation_time")]
        public string ObservationTime { get; set; }

        [JsonProperty("temp_C")]
        public string TempC { get; set; }

        [JsonProperty("temp_F")]
        public string TempF { get; set; }

        [JsonProperty("weatherCode")]
        public string WeatherCode { get; set; }

        [JsonProperty("weatherIconUrl")]
        public IList<WeatherIconUrl> WeatherIconUrl { get; set; }

        [JsonProperty("windspeedMiles")]
        public string WindspeedMiles { get; set; }

        [JsonProperty("windspeedKmph")]
        public string WindspeedKmph { get; set; }

        [JsonProperty("winddirDegree")]
        public string WinddirDegree { get; set; }

        [JsonProperty("winddir16Point")]
        public string Winddir16Point { get; set; }

        [JsonProperty("precipMM")]
        public string PrecipMM { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("cloudcover")]
        public string Cloudcover { get; set; }

        [JsonProperty("FeelsLikeC")]
        public string FeelsLikeC { get; set; }

        [JsonProperty("FeelsLikeF")]
        public string FeelsLikeF { get; set; }

        [JsonProperty("uvIndex")]
        public int UvIndex { get; set; }
    }
}