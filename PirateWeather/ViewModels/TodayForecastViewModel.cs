using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PirateWeather.AppState;
using PirateWeather.Models;
using PirateWeather.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.ViewModels
{
    public partial class TodayForecastViewModel : BaseViewModel
    {
        private readonly AppStateInfo AppState;

        [ObservableProperty]
        CurrentForecastModel currentForecast;

        [ObservableProperty]
        ObservableCollection<HourlyForecastModel> hourlyForecasts;

        [ObservableProperty]
        string errorMessage;

        public TodayForecastViewModel(AppStateInfo _AppState) 
        {
            isBusy = true;
            AppState = _AppState;
            HourlyForecasts = new ObservableCollection<HourlyForecastModel>();
            if(AppState.HasCompletedQuery)
            {
                GetData();
            }
            else
            {
                AppState.NetQueryCompletedEvent += _AppState_NetQueryCompletedEvent;
            }
            
        }

        private void _AppState_NetQueryCompletedEvent(object sender, bool HasCompletedSuccessfully)
        {
            if(HasCompletedSuccessfully)
            {
                CurrentForecast = AppState.CurrentForecast;

                List<HourlyForecastModel> hourlyForecastModels = AppState.HourlyForecasts;
                foreach(HourlyForecastModel Forecast in hourlyForecastModels)
                {
                    HourlyForecasts.Add(Forecast);
                }

            }
            else
            {
                ErrorMessage = "Could not get weather data";
            }
            IsBusy = false;
        }

        [RelayCommand]
        public async Task ViewHourlyForecast(HourlyForecastModel hourlyForecast)
        {
            await Shell.Current.GoToAsync(nameof(HourlyForecastView), true, new Dictionary<string, Object> { { "HourlyForecast", hourlyForecast } });
        }

        private void GetData()
        {
            CurrentForecast = AppState.CurrentForecast;

            List<HourlyForecastModel> hourlyForecastModels = AppState.HourlyForecasts;
            foreach (HourlyForecastModel Forecast in hourlyForecastModels)
            {
                HourlyForecasts.Add(Forecast);
            }
        }

    }
}
