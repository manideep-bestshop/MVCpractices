using Microsoft.AspNetCore.Mvc;
using PassingValuesToView.Models;
using System.Diagnostics;

namespace PassingValuesToView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var tutorials = new List<Tutorial>
            {
                new Tutorial{Id=1,Name="C#",Description="C#  tutorials"},
                new Tutorial{Id=2,Name="MVC",Description="MVC Tutorials"}
            };

            ViewBag.Tutorials= tutorials;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
