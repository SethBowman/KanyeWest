

using Newtonsoft.Json.Linq;

var client = new HttpClient();

var kanyeURL = "https://api.kanye.rest/";

var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

//Console.WriteLine(kanyeResponse);

var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

Console.WriteLine(kanyeQuote);


