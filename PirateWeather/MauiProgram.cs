using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using PirateWeather.AppState;
using PirateWeather.ViewModels;
using PirateWeather.Views;

namespace PirateWeather
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
               
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<PirateWeatherHttpClient>();
            builder.Services.AddSingleton<AppStateInfo>();
            builder.Services.AddTransient<HourlyForecastViewModel>();
            builder.Services.AddTransient<HourlyForecastView>();
            builder.Services.AddSingleton<DailyForecastView>();
            builder.Services.AddSingleton<DailyForecastViewModel>();
            builder.Services.AddSingleton<TodayForecastView>();
            builder.Services.AddSingleton<TodayForecastViewModel>();

                return builder.Build();
        }
    }
}