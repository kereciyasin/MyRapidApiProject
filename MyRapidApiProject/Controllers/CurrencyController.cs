using Microsoft.AspNetCore.Mvc;

namespace MyRapidApiProject.Controllers
{
    public class CurrencyController : Controller
    {
        public async Task<IActionResult> CurrencyList()
        {


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=EUR&amount=750"),
                Headers =
    {
        { "x-rapidapi-key", "254c94ea90msh20f1ab536df1b2cp1b0996jsn9b0a09805501" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
            return View();
        }
    }
}
