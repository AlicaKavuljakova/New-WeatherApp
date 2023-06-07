using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherMap
    {
        public static double GetTemp(string url)
        {
            var client=new HttpClient();
          var response=  client.GetStringAsync(url).Result;
            var temp= double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
          return  temp;
            
        }
        public static string GetCity(string url)
        {
        var client= new HttpClient();
            string response = client.GetStringAsync(url).Result;
            string city = JObject.Parse(response)["name"].ToString();
            return city;
        }


    }
}
