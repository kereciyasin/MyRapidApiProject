using Microsoft.AspNetCore.Mvc;

namespace MyRapidApiProject.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult MovieList()
        {
            return View();
        }
    }
}
