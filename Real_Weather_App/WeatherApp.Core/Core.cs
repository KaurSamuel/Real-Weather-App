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
        public static async Task<Weather> GetWeather(string zipCode, string City, string CityID, bool forecast)
        {
                string key = "9c53713d4a89d60615482a2ad46a4e45";
                string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + City + "&APPID=" + key + "&units=metric";

                dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);
                var weather = new Weather();
                weather.Temperature = (string)results["main"]["temp"] + " C";
                weather.Humidity = (string)results["main"]["humidity"] + "%";
                weather.wind_speed = (string)results["wind"]["speed"] + " m/s";
                weather.description = (string)results["weather"][0]["main"];
                weather.ID = (string)results["id"];
                return weather;
        }

        public static async Task<List<Weather>> GetWeatherForecast(string CityID)
        {
            var weatherforecast = new Weather();
            List<Weather> weather = new List<Weather>() { };

            string key = "9c53713d4a89d60615482a2ad46a4e45";
            string queryString = "api.openweathermap.org/data/2.5/forecast?id=" + CityID + "&APPID=" + key + "&units=metric";
            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);
            for (int i = 0; i < 39; i+=8)
            {
                weatherforecast.Temperature = (string)results["list"][i]["main"]["temp"] + "C";
                weatherforecast.description = (string)results["list"][i]["weather"][0]["description"];
                weatherforecast.Date = (string)results["list"][i]["dt_txt"];
                weather.Add(weatherforecast);
            }
            return weather;
        }
   }
}
