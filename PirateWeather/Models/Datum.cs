using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.Models
{
    public class Datum
    {
        public int Time { get; set; }
        public float PrecipIntensity { get; set; }
        public float PrecipProbability { get; set; }
        public float PrecipIntensityError { get; set; }
        public string PrecipType { get; set; }
    }
}
