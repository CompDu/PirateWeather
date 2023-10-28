using PirateWeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace PirateWeather.AppState
{
    public class AppStateInfo
    {
        public List<HourlyForecastModel> HourlyForecasts { get; set; }

        public List<DailyForecastModel> DailyForecasts { get; set; }    

        public CurrentForecastModel CurrentForecast { get; set; }

        private readonly PirateWeatherHttpClient Client;

        public string ErrorMessage;

        public event EventHandler<bool> NetQueryCompletedEvent;

        public bool HasCompletedQuery;

        public AppStateInfo(PirateWeatherHttpClient _Client)
        {
            Client = _Client;
            ErrorMessage = string.Empty; 
            HourlyForecasts = new List<HourlyForecastModel>();
            DailyForecasts = new List<DailyForecastModel>();
            HasCompletedQuery = false;
            getWeather();
        }

        public async Task getWeather()
        {
            
            try
            {
                WeatherRoot weatherRoot = await Client.GetWeatherAsync();

                if (weatherRoot is not null)
                {
                    ProcessWeather(ref weatherRoot);
                    HasCompletedQuery = true;
                    NetQueryCompletedEvent?.Invoke(this,true);
                    
                }
                else
                {
                    ErrorMessage = "Could not get weather";
                    HasCompletedQuery = true;
                    NetQueryCompletedEvent?.Invoke(this, false);
                    
                }
               
            }
            catch (Exception)
            {
            
                ErrorMessage = "Could not get weather";
                HasCompletedQuery = true;
                NetQueryCompletedEvent?.Invoke(this, false);
               
            }

        }


       

        private void ProcessWeather(ref WeatherRoot weatherRoot)
        {
            //Current Forcast
            CurrentForecast = weatherRoot.currently;
           
            DateTime FTime = new(1970, 1, 1);
            DateTime TempTime;
            TempTime = FTime.AddSeconds(CurrentForecast.Time);

            CurrentForecast.Day = TempTime.DayOfWeek;

            Datum1[] TempDatum1 = weatherRoot.hourly.Data;
            HourlyForecastModel hourlyForecastModel;
           

            foreach (var Forecast in TempDatum1)
            {
                hourlyForecastModel = new HourlyForecastModel()
                {
                    Time = Forecast.Time,
                    UvIndex = Forecast.UvIndex,
                    Icon = Forecast.Icon,
                    PrecipAccumulation = Forecast.PrecipAccumulation,
                    PrecipIntensity = Forecast.PrecipIntensity,
                    PrecipIntensityError = Forecast.PrecipIntensityError,
                    PrecipProbability = Forecast.PrecipProbability * 100,
                    PrecipType = Forecast.PrecipType,
                    Pressure = Forecast.Pressure,
                    DewPoint = Forecast.DewPoint,
                    ApparentTemperature = Forecast.ApparentTemperature,
                    CloudCover = Forecast.CloudCover,
                    Humidity = Forecast.Humidity,
                    Visibility = Forecast.Visibility,
                    Ozone = Forecast.Ozone,
                    Summary = Forecast.Summary,
                    Temperature = Forecast.Temperature,
                    WindBearing = Forecast.WindBearing,
                    WindGust = Forecast.WindGust,
                    WindSpeed = Forecast.WindSpeed

                };

                FTime = new DateTime(1970, 1, 1);
                TempTime = FTime.AddSeconds(hourlyForecastModel.Time);
                hourlyForecastModel.Day = TempTime.DayOfWeek;
                hourlyForecastModel.Hour = TempTime.Hour;

               
                HourlyForecasts.Add(hourlyForecastModel);
            }

           

            //Daily Forecasts
            Datum2[] TempDatum2 = weatherRoot.daily.data;
            DailyForecastModel dailyForecastModel;
           

            foreach (var Forecast in TempDatum2)
            {
                dailyForecastModel = new DailyForecastModel()
                {
                    DewPoint = Forecast.DewPoint,
                    ApparentTemperatureHigh = Forecast.ApparentTemperatureHigh,
                    ApparentTemperatureHighTime = Forecast.ApparentTemperatureHighTime,
                    ApparentTemperatureLow = Forecast.ApparentTemperatureLow,
                    ApparentTemperatureLowTime = Forecast.ApparentTemperatureLowTime,
                    ApparentTemperatureMax = Forecast.ApparentTemperatureMax,
                    ApparentTemperatureMaxTime = Forecast.ApparentTemperatureMaxTime,
                    ApparentTemperatureMin = Forecast.ApparentTemperatureMin,
                    ApparentTemperatureMinTime = Forecast.ApparentTemperatureMinTime,
                    PrecipAccumulation = Forecast.PrecipAccumulation,
                    PrecipIntensity = Forecast.PrecipIntensity,
                    PrecipIntensityMax = Forecast.PrecipIntensityMax,
                    PrecipIntensityMaxTime = Forecast.PrecipIntensityMaxTime,
                    PrecipProbability = Forecast.PrecipProbability * 100,
                    PrecipType = Forecast.PrecipType,
                    Pressure = Forecast.Pressure,
                    MoonPhase = Forecast.MoonPhase,
                    CloudCover = Forecast.CloudCover,
                    Humidity = Forecast.Humidity,
                    WindBearing = Forecast.WindBearing,
                    WindGust = Forecast.WindGust,
                    WindGustTime = Forecast.WindGustTime,
                    WindSpeed = Forecast.WindSpeed,
                    Icon = Forecast.Icon,
                    Summary = Forecast.Summary,
                    SunriseTime = Forecast.SunriseTime,
                    SunsetTime = Forecast.SunsetTime,
                    Time = Forecast.Time,
                    UvIndex = Forecast.UvIndex,
                    UvIndexTime = Forecast.UvIndexTime
                };
               
                FTime = new DateTime(1970, 1, 1);
                TempTime = FTime.AddSeconds(dailyForecastModel.Time);
                dailyForecastModel.Day = TempTime.DayOfWeek;
                DailyForecasts.Add(dailyForecastModel);

            }
           
        }
    


}
}
