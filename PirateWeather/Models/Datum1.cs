﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateWeather.Models
{
    public class Datum1
    {
        public int Time { get; set; }
        public string Icon { get; set; }
        public string Summary { get; set; }
        public float PrecipIntensity { get; set; }
        public float PrecipProbability { get; set; }
        public float PrecipIntensityError { get; set; }
        public float PrecipAccumulation { get; set; }
        public string PrecipType { get; set; }
        public float Temperature { get; set; }
        public float ApparentTemperature { get; set; }
        public float DewPoint { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public float WindSpeed { get; set; }
        public float WindGust { get; set; }
        public int WindBearing { get; set; }
        public float CloudCover { get; set; }
        public float UvIndex { get; set; }
        public float Visibility { get; set; }
        public float Ozone { get; set; }
    }
}
