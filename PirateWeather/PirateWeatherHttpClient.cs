using PirateWeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PirateWeather
{
    public class PirateWeatherHttpClient
    {
        private HttpClient client;
        
        public PirateWeatherHttpClient() 
        {
            client = new HttpClient();
        }
        
        public async Task<WeatherRoot> GetWeatherAsync()
        {
           
            var request = new HttpRequestMessage(HttpMethod.Get,"https://github.com/CompDu/PirateWeather/blob/master/PirateWeather/PirateWeather.json"); 
            HttpResponseMessage response = await client.SendAsync(request);
            if(response.IsSuccessStatusCode)
            {
                string myString = await response.Content.ReadAsStringAsync();

                WeatherRoot weatherRoot = JsonConvert.DeserializeObject<WeatherRoot>(myString);
                
                return weatherRoot;
            }
            else
            {
                
                return null;
            }
        }


    }
}