using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string zipCode)
        {
            string key = "a519d2565f58343b5f157d056e658aca";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=London&APPID="+key;

            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);
            var weather = new Weather();
            weather.Temperature = (string)results["main"]["temp"] + " C";
            return weather;
        }
    }
}
