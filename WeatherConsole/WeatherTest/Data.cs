using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherTest
{
    public class Data
    {
        [JsonProperty("request")]
        public IList<Request> Request { get; set; }

        [JsonProperty("current_condition")]
        public IList<CurrentCondition> CurrentCondition { get; set; }

        [JsonProperty("weather")]
        public IList<Weather> Weather { get; set; }
    }
}
