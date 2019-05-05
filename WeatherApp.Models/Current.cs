using Newtonsoft.Json;
using System;

namespace WeatherApp.Models
{
    public class Current
    {
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("temp_c")]
        public double TempDegreeCelsius { get; set; }
        
        [JsonProperty("condition")]
        public Condition Condition { get; set; }
        
        [JsonProperty("wind_kph")]
        public double WindSpeed { get; set; }
        
        [JsonProperty("wind_dir")]
        public string WindDirection { get; set; }
        
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        
        [JsonProperty("feelslike_c")]
        public double FeelsLikeCelsius { get; set; }
        
        [JsonProperty("vis_km")]
        public double Visiblity { get; set; } //in km
    }
}