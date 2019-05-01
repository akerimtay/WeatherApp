using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Feature
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
