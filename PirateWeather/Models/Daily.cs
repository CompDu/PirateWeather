using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.Models
{
    public class Daily
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public Datum2[] data { get; set; }
    }
}
