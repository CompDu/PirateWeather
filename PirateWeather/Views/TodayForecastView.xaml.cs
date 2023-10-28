using PirateWeather.ViewModels;

namespace PirateWeather.Views;

public partial class TodayForecastView : ContentPage
{
	public TodayForecastView(TodayForecastViewModel todayForecastViewModel)
	{
		InitializeComponent();
		BindingContext = todayForecastViewModel;
	}
}