using WeatherAppMaui.Pages;

namespace WeatherAppMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WeatherPageInfo();
        }
    }
}
