using Real_Weather_App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core
{
    class Core
    {
        public static async Task<Weather> GetWeather(string zipCode)
        {


            string key = "9c53713d4a89d60615482a2ad46a4e45";
            string querystring = "http://api.openweathermap.org/data/2.5/weather?q=London";

            dynamic results = await DataService.GetDataFromService(querystring).ConfigureAwait(false);
            var Weather = new Weather();
            Weather.Temperature = (string)results["main"]["temp"] + "C";
            return Weather; 
                


        }
    }
}
