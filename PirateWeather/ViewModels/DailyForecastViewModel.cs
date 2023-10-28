using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    public partial class DailyForecastViewModel:BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<DailyForecastModel> dailyForecasts;

        [ObservableProperty]
        public string errorMessage;

        private readonly AppStateInfo appState;

        public DailyForecastViewModel(AppStateInfo appStateInfo) 
        {
            IsBusy = true;
            appState = appStateInfo;
            errorMessage = string.Empty;
            DailyForecasts = new ObservableCollection<DailyForecastModel>();
            if (appStateInfo.HasCompletedQuery)
            {
                GetData();
            }
            else
            {
                appStateInfo.NetQueryCompletedEvent += AppStateInfo_NetQueryCompletedEvent;
            }
        }

        private void AppStateInfo_NetQueryCompletedEvent(object sender, bool HasCompletedSuccessfully)
        {
            if (HasCompletedSuccessfully)
            { 
                List<DailyForecastModel> dailyForecastModels = appState.DailyForecasts;
                foreach (DailyForecastModel Forecast in dailyForecastModels)
                {
                    DailyForecasts.Add(Forecast);
                }
            }
            IsBusy = false;
        }

        private void GetData()
        {
            List<DailyForecastModel> dailyForecastModels = appState.DailyForecasts;
            foreach (DailyForecastModel Forecast in dailyForecastModels)
            {
                DailyForecasts.Add(Forecast);
            }
            IsBusy = false;
        }
    }
}
