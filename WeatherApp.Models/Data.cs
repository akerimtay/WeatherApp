using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApp.Models
{
    public class Data
    {
        [JsonProperty("request")]
        public List<Request> Request { get; set; }

        [JsonProperty("current_condition")]
        public List<CurrentCondition> CurrentCondition { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }
    }
}