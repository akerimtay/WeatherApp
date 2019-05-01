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

            string json = downloader.DownloadRawJsonData("http://api.worldweatheronline.com/premium/v1/weather.ashx?key=63f4f19fa98343e58e950508193004&q=New+York&format=json&num_of_days=7");
            var data = JsonConvert.DeserializeObject<Feature>(json);
            
        }
    }
}
