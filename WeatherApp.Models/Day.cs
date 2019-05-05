using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class Day
    {
        [JsonProperty("maxtemp_c")]
        public double MaxTemp { get; set; }
        
        [JsonProperty("mintemp_c")]
        public double MinTemp { get; set; }
        
        [JsonProperty("maxwind_kph")]
        public double MaxWindSpeed { get; set; }
        
        [JsonProperty("avgvis_km")]
        public double AvengerVisiblity { get; set; }
        
        [JsonProperty("avghumidity")]
        public double AvengerHumidity { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }
    }
}