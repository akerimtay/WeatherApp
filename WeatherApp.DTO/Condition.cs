using Newtonsoft.Json;

namespace WeatherApp.DTO
{
    public class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}