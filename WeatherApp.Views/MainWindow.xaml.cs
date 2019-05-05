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

            string json = downloader.DownloadRawJsonData("http://api.apixu.com/v1/forecast.json?key=041385abb58343f9a69145540190505&q=Astana&days=7");
            var feature = JsonConvert.DeserializeObject<Feature>(json);

            string a = "";
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
