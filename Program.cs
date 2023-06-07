// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using WeatherApp;

string key = File.ReadAllText("appsettings.json");
string apiKey= JObject.Parse(key).GetValue("APIKey").ToString();
Console.WriteLine("What is your zipcode?");
var zipCode = Console.ReadLine();


string url = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={apiKey}";
Console.WriteLine($"It is currently: {WeatherMap.GetTemp(url)} degrees Farenheit in {WeatherMap.GetCity(url)}");