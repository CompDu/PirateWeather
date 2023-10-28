using PirateWeather.ViewModels;

namespace PirateWeather.Views;

public partial class DailyForecastView : ContentPage
{
	public DailyForecastView(DailyForecastViewModel dailyForecastViewModel)
	{
		InitializeComponent();
		BindingContext = dailyForecastViewModel;
	}
}