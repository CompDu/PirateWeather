using PirateWeather.ViewModels;

namespace PirateWeather.Views;

public partial class HourlyForecastView : ContentPage
{
	public HourlyForecastView(HourlyForecastViewModel hourlyForecastViewModel)
	{
		InitializeComponent();
		BindingContext = hourlyForecastViewModel;
	}
}