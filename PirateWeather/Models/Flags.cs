using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.Models
{
    public class Flags
    {
        public string[] sources { get; set; }
        public Sourcetimes sourceTimes { get; set; }
        public long neareststation { get; set; }
        public string units { get; set; }
        public string version { get; set; }
    }
}
