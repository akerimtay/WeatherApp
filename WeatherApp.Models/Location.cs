using Newtonsoft.Json;
using System;

namespace WeatherApp.Models
{
    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("country")]
        public string Country { get; set; }
        
        [JsonProperty("localtime")]
        public DateTime LocalTime { get; set; }
    }
}