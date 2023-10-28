using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.Models
{
    public class DailyForecastModel
    {
       

        public long Time { get; set; }

        public DayOfWeek Day { get; set; }
        public string Icon { get; set; }
        public string Summary { get; set; }
        public long SunriseTime { get; set; }
        public long SunsetTime { get; set; }
        public float MoonPhase { get; set; }
        public float PrecipIntensity { get; set; }
        public float PrecipIntensityMax { get; set; }
        public long PrecipIntensityMaxTime { get; set; }
        public float PrecipProbability { get; set; }
        public float PrecipAccumulation { get; set; }
        public string PrecipType { get; set; }
        public float TemperatureHigh { get; set; }
        public long TemperatureHighTime { get; set; }
        public float TemperatureLow { get; set; }
        public long TemperatureLowTime { get; set; }
        public float ApparentTemperatureHigh { get; set; }
        public long ApparentTemperatureHighTime { get; set; }
        public float ApparentTemperatureLow { get; set; }
        public long ApparentTemperatureLowTime { get; set; }
        public float DewPoint { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public float WindSpeed { get; set; }
        public float WindGust { get; set; }
        public long WindGustTime { get; set; }
        public float WindBearing { get; set; }
        public float CloudCover { get; set; }
        public float UvIndex { get; set; }
        public long UvIndexTime { get; set; }
        public float Visibility { get; set; }
        public float TemperatureMin { get; set; }
        public long TemperatureMinTime { get; set; }
        public float TemperatureMax { get; set; }
        public long TemperatureMaxTime { get; set; }
        public float ApparentTemperatureMin { get; set; }
        public long ApparentTemperatureMinTime { get; set; }
        public float ApparentTemperatureMax { get; set; }
        public long ApparentTemperatureMaxTime { get; set; }

    }
}
