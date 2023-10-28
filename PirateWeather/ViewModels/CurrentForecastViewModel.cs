using CommunityToolkit.Mvvm.ComponentModel;
using PirateWeather.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PirateWeather.ViewModels
{
    [QueryProperty("CurrentForecastModel", "currentForecastModel")]
    
    public partial class CurrentForecastViewModel : BaseViewModel
    {
        [ObservableProperty]
        CurrentForecastModel currentForecastModel;

        [ObservableProperty]
        ObservableCollection<HourlyForecastModel> hourlyForecasts;

        public CurrentForecastViewModel()
        {
            hourlyForecasts = new ObservableCollection<HourlyForecastModel>();
        }

    }
}
