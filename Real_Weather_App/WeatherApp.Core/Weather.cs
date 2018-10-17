using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

namespace Real_Weather_App
{
    public class Weather
    {
        public string Temperature { get; set; } = "";
        public string Pressure { get; set; } = "";
        public string Humidity { get; set; } = "";

        public string wind_speed { get; set; } = "";
        public string wind_deg { get; set; } = "";

        public string description { get; set; } = "";
        public string ID { get; set; } = "";
        public string Date { get; set; } = "";
    }
}