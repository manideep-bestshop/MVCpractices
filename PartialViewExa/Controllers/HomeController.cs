using Microsoft.AspNetCore.Mvc;
using PartialViewExa.Models;
using System.Diagnostics;

namespace PartialViewExa.Controllers
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
            Address ad = new Address();
            ad.Country = "India";
            ad.State = "Telangana";
            ad.City = "Hyd";
            ad.PostalCode = "500038";

            return View(ad);
        }
        public IActionResult About()
        {
           
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
