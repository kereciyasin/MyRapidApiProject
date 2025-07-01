using Microsoft.AspNetCore.Mvc;

namespace MyRapidApiProject.Controllers
{
    public class MovieController : Controller
    {
        public async Task<IActionResult> MovieList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb236.p.rapidapi.com/api/imdb/top250-movies"),
                Headers =
    {
        { "x-rapidapi-key", "254c94ea90msh20f1ab536df1b2cp1b0996jsn9b0a09805501" },
        { "x-rapidapi-host", "imdb236.p.rapidapi.com" },
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
