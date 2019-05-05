using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeatherApp.Models;
using WeatherApp.Services;
using WeatherApp.Services.Abstract;

namespace WeatherApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ILogger logger = new FileLogger();
            IDownloader downloader = new Downloader(logger);

            string json = downloader.DownloadRawJsonData("https://api.apixu.com/v1/forecast.json?key=041385abb58343f9a69145540190505&q=astana&days=7");
            var feature = JsonConvert.DeserializeObject<Feature>(json);

            List<CardViewModel> cards = new List<CardViewModel>();

            var card = new CardViewModel
            {
                Date = feature.Forecast.ForecastDays[0].Date,
                MaxTemp = feature.Forecast.ForecastDays[0].Day.MaxTemp,
                MinTemp = feature.Forecast.ForecastDays[0].Day.MinTemp,
                MaxWindSpeed = feature.Forecast.ForecastDays[0].Day.MaxWindSpeed,
                AvengerHumidity = feature.Forecast.ForecastDays[0].Day.AvengerHumidity,
                AvengerVisiblity = feature.Forecast.ForecastDays[0].Day.AvengerVisiblity,
                Icon = feature.Forecast.ForecastDays[0].Day.Condition.Icon,
                Text = feature.Forecast.ForecastDays[0].Day.Condition.Text
            };

            cityNameTextBlock.Text += feature.Location.Name + ", " + feature.Location.Country;

            //string a = "";
        }

        private void WindowClosing(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ClearTextBox(object sender, MouseButtonEventArgs e)
        {
            cityNameTextBox.Text = "";
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
