


using PirateWeather.Views;

namespace PirateWeather
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HourlyForecastView),typeof(HourlyForecastView));
           
        }
    }
}