using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.Models
{
    public class CurrentForecastModel
    {
        public long Time { get; set; }

        public DayOfWeek Day { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public int NearestStormDistance { get; set; }
        public int NearestStormBearing { get; set; }
        public float PrecipIntensity { get; set; }
        public float PrecipProbability { get; set; }
        public float PrecipIntensityError { get; set; }
        public string PrecipType { get; set; }
        public float Temperature { get; set; }
        public float ApparentTemperature { get; set; }
        public float DewPoint { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public float WindSpeed { get; set; }
        public float WindGust { get; set; }
        public float WindBearing { get; set; }
        public float CloudCover { get; set; }
        public float UvIndex { get; set; }
        public float Visibility { get; set; }
        public float Ozone { get; set; }
        public List<HourlyForecastModel> HourlyForecasts { get; set; }
    }
}
