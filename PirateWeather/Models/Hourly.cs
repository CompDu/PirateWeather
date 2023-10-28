using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.Models
{
    public class Hourly
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public Datum1[] Data { get; set; }
    }
}
