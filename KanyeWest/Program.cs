

using Newtonsoft.Json.Linq;

var client = new HttpClient();

var kanyeURL = "https://api.kanye.rest/";

var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

//Console.WriteLine(kanyeResponse);

var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

//Console.WriteLine(kanyeQuote);


var apiKeyObj = File.ReadAllText("appsettings.json");

var apiKey = JObject.Parse(apiKeyObj).GetValue("apiKey");

var url = $"http://api.openweathermap.org/data/2.5/weather?zip=35091&appid={apiKey}&units=imperial";

Console.WriteLine(apiKey);