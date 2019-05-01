using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class WeatherIconUrl
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}