using Newtonsoft.Json;
using System;

namespace WeatherApp.DTO
{
    public class Forecastday
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("day")]
        public Day Day { get; set; }
    }
}