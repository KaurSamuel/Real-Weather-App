using Real_Weather_App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core
{
   public class Core
    {
        // 9c53713d4a89d60615482a2ad46a4e45
        public static async Task<Weather> GetWeather(string zipCode)
        {
            string key = "9c53713d4a89d60615482a2ad46a4e45";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=London&APPID=" + key + "&units=metric";

            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);
            var weather = new Weather();
            weather.Temperature = (string)results["main"]["temp"] + " C";
            weather.Humidity = (string)results["main"]["humidity"] +"%";
            weather.Pressure = (string)results["main"]["pressure"]+ "bar";
            weather.wind_speed = (string)results["wind"]["speed"]+ "m/s";
            weather.wind_deg = (string)results["wind"]["deg"];
            weather.description = (string)results["0"]["main"];
            return weather;
        }
    }
}
