using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.Models
{
    public class WeatherRoot
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string timezone { get; set; }
        public long offset { get; set; }
        public long elevation { get; set; }
        public CurrentForecastModel currently { get; set; }
       // public Minutely minutely { get; set; }
        public Hourly hourly { get; set; }
        public Daily daily { get; set; }
        public Flags flags { get; set; }
    }
}
