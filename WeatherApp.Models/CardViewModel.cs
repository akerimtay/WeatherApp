using System;

namespace WeatherApp.Models
{
    public class CardViewModel
    {
        public DateTime Date { get; set; }
        public double MaxTemp { get; set; }
        public double MinTemp { get; set; }
        public double MaxWindSpeed { get; set; }
        public double AvengerVisiblity { get; set; }
        public double AvengerHumidity { get; set; }

        public string Text { get; set; }
        public string Icon { get; set; }
    }
}
