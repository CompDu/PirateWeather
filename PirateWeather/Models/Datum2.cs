using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.Models
{
    public class Datum2
    {
        public int Time { get; set; }
        public string Icon { get; set; }
        public string Summary { get; set; }
        public int SunriseTime { get; set; }
        public int SunsetTime { get; set; }
        public float MoonPhase { get; set; }
        public float PrecipIntensity { get; set; }
        public float PrecipIntensityMax { get; set; }
        public int PrecipIntensityMaxTime { get; set; }
        public float PrecipProbability { get; set; }
        public float PrecipAccumulation { get; set; }
        public string PrecipType { get; set; }
        public float TemperatureHigh { get; set; }
        public int TemperatureHighTime { get; set; }
        public float TemperatureLow { get; set; }
        public int TemperatureLowTime { get; set; }
        public float ApparentTemperatureHigh { get; set; }
        public int ApparentTemperatureHighTime { get; set; }
        public float ApparentTemperatureLow { get; set; }
        public int ApparentTemperatureLowTime { get; set; }
        public float DewPoint { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public float WindSpeed { get; set; }
        public float WindGust { get; set; }
        public int WindGustTime { get; set; }
        public float WindBearing { get; set; }
        public float CloudCover { get; set; }
        public float UvIndex { get; set; }
        public int UvIndexTime { get; set; }
        public float Visibility { get; set; }
        public float TemperatureMin { get; set; }
        public int TemperatureMinTime { get; set; }
        public float TemperatureMax { get; set; }
        public int TemperatureMaxTime { get; set; }
        public float ApparentTemperatureMin { get; set; }
        public int ApparentTemperatureMinTime { get; set; }
        public float ApparentTemperatureMax { get; set; }
        public int ApparentTemperatureMaxTime { get; set; }
    }
}
