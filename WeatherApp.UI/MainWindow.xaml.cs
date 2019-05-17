using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using WeatherApp.DTO;
using WeatherApp.Services;

namespace WeatherApp.UI
{
    public partial class MainWindow : Window
    {
        private Feature _features;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private async Task SearchCityAsync(string city)
        {
            Downloader downloader = new Downloader();
            string json = "";

            city = city.Trim();
            city = city.Replace(" ", "+");

            try
            {
                json = await downloader.DownloadRawJsonDataAsync($"https://api.apixu.com/v1/forecast.json?key=041385abb58343f9a69145540190505&q={city}&days=7");
            }
            catch(Exception)
            {
                MessageBox.Show($"We can't find the city. Please try again!");
                return;
            }

            _features = JsonConvert.DeserializeObject<Feature>(json);

            cityNameTextBlock.Text = $"City: {_features.Location.Name}, {_features.Location.Country}";
            lastUpdatedDateTextBlock.Text = $"Last updated: {_features.Location.LocalTime.ToLongTimeString()}";

            //Fill Cards
            for (int i = 0; i < _features.Forecast.ForecastDays.Count; i++)
            {
                var header = $"{_features.Forecast.ForecastDays[i].Date.DayOfWeek}, " +
                    $"{_features.Forecast.ForecastDays[i].Date.Day}.{_features.Forecast.ForecastDays[i].Date.Month}.{_features.Forecast.ForecastDays[i].Date.Year}";

                var conditionText = _features.Forecast.ForecastDays[i].Day.Condition.Text;
                var image = GetBitMapOfImage(_features.Forecast.ForecastDays[i].Day.Condition.Icon.Insert(0, "http:"));

                var featuresText = $"{_features.Forecast.ForecastDays[i].Day.MaxTemp} 'C " +
                                    $"\n{_features.Forecast.ForecastDays[i].Day.MinTemp} 'C " +
                                    $"\n{_features.Forecast.ForecastDays[i].Day.Humidity} % " +
                                    $"\n{_features.Forecast.ForecastDays[i].Day.Visiblity} km " +
                                    $"\n{_features.Forecast.ForecastDays[i].Day.WindSpeed} km/h";

                switch (i + 1)
                {
                    case 1:
                        firstDayGroupBox.Header = header;
                        firstDayConditionTextBlock.Text = conditionText;
                        firstDayImage.Source = image;
                        firstDayFeature.Text = featuresText;
                        break;
                    case 2:
                        secondDayGroupBox.Header = header;
                        secondDayConditionTextBlock.Text = conditionText;
                        secondDayImage.Source = image;
                        secondDayFeature.Text = featuresText;
                        break;
                    case 3:
                        thirdDayGroupBox.Header = header;
                        thirdDayConditionTextBlock.Text = conditionText;
                        thirdDayImage.Source = image;
                        thirdDayFeature.Text = featuresText;
                        break;
                    case 4:
                        fourthDayGroupBox.Header = header;
                        fourthDayConditionTextBlock.Text = conditionText;
                        fourthDayImage.Source = image;
                        fourthDayFeature.Text = featuresText;
                        break;
                    case 5:
                        fifthDayGroupBox.Header = header;
                        fifthDayConditionTextBlock.Text = conditionText;
                        fifthDayImage.Source = image;
                        fifthDayFeature.Text = featuresText;
                        break;
                    case 6:
                        sixthDayGroupBox.Header = header;
                        sixthDayConditionTextBlock.Text = conditionText;
                        sixthDayImage.Source = image;
                        sixthDayFeature.Text = featuresText;
                        break;
                    case 7:
                        seventhDayGroupBox.Header = header;
                        seventhDayConditionTextBlock.Text = conditionText;
                        seventhDayImage.Source = image;
                        seventhDayFeature.Text = featuresText;
                        break;
                }
            }
        }

        private async void WindowLoaded(object sender, RoutedEventArgs e)
        {
            await SearchCityAsync("Astana");
        }

        public BitmapImage GetBitMapOfImage(string url)
        {
            BitmapImage bitmap = new BitmapImage();

            bitmap.BeginInit();
            bitmap.UriSource = new Uri(url);
            bitmap.EndInit();

            return bitmap;
        }

        private void SearchCityButtonClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchCityTextBox.Text))
            {
                MessageBox.Show("Please, enter a city name!");
                return;
            }

            SearchCityAsync(searchCityTextBox.Text);
        }

        private void SearchCityKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                if (string.IsNullOrWhiteSpace(searchCityTextBox.Text))
                {
                    MessageBox.Show("Please, enter a city name!");
                    return;
                }

                SearchCityAsync(searchCityTextBox.Text);
            }
        }
    }
}