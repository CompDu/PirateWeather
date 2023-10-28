using CommunityToolkit.Mvvm.ComponentModel;
using PirateWeather.AppState;
using PirateWeather.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.ViewModels
{
    [QueryProperty("HourlyForecast","HourlyForecast")]
    public partial class HourlyForecastViewModel : BaseViewModel
    {
        [ObservableProperty]
        HourlyForecastModel hourlyForecast;

        public HourlyForecastViewModel()
        {
            Title = "Hourly Weather";
        }

        
    }
}
