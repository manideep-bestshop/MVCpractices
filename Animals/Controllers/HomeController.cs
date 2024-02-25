using Animals.Models;
using Library;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Animals.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public Class1 class1;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            class1= new Class1();
        }

        public IActionResult Index()
        {
            class1.Name = "Jilly";
            class1.AnimalType = AnimalType.Domestic;
            return View(class1);
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
