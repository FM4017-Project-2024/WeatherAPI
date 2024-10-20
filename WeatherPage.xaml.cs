namespace MauiTest;

public partial class WeatherPage : ContentPage
{
    private readonly WeatherService weatherService = new WeatherService();

    public WeatherPage()
    {
        InitializeComponent();
        LoadWeatherData();
    }

    private async void LoadWeatherData()
    {
        // Use the WeatherService to fetch the weather data
        string weatherData = await weatherService.GetWeatherAsync(59.7076562, 10.1559495, 90, 0);

        // Assuming you have a Label in XAML with the name 'weatherLabel'
        weatherLabel.Text = weatherData;
    }
}
