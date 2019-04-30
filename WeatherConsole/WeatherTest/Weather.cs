namespace WeatherTest
{
    public class Weather
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("astronomy")]
        public IList<Astronomy> Astronomy { get; set; }

        [JsonProperty("maxtempC")]
        public string MaxtempC { get; set; }

        [JsonProperty("maxtempF")]
        public string MaxtempF { get; set; }

        [JsonProperty("mintempC")]
        public string MintempC { get; set; }

        [JsonProperty("mintempF")]
        public string MintempF { get; set; }

        [JsonProperty("totalSnow_cm")]
        public string TotalSnowCm { get; set; }

        [JsonProperty("sunHour")]
        public string SunHour { get; set; }

        [JsonProperty("uvIndex")]
        public string UvIndex { get; set; }

        [JsonProperty("hourly")]
        public IList<Hourly> Hourly { get; set; }
    }
}