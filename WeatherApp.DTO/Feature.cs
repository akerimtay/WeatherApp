using Newtonsoft.Json;

namespace WeatherApp.DTO
{
    public class Feature
    {
        [JsonProperty("location")]
        public Location Location { get; set; }
        
        [JsonProperty("forecast")]
        public Forecast Forecast { get; set; }
    }
}
