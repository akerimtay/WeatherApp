using Newtonsoft.Json;

namespace WeatherApp.DTO
{
    public class Day
    {
        [JsonProperty("maxtemp_c")]
        public double MaxTemp { get; set; }

        [JsonProperty("mintemp_c")]
        public double MinTemp { get; set; }

        [JsonProperty("maxwind_kph")]
        public double WindSpeed { get; set; }

        [JsonProperty("avgvis_km")]
        public double Visiblity { get; set; }

        [JsonProperty("avghumidity")]
        public double Humidity { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }
    }
}