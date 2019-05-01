using Newtonsoft.Json;
using System;

namespace WeatherApp.Models
{
    public class Weather
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("maxtempC")]
        public int MaxTempC { get; set; }

        [JsonProperty("mintempC")]
        public int MinTempC { get; set; }
    }
}