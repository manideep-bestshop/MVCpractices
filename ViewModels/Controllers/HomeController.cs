using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModels.Models;
using ViewModels.ViewModels;

namespace ViewModels.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private List<Animals> animals = new List<Animals>()
        {
            new Animals {Id=1, Name="Monkey"},
            new Animals {Id=2,Name="Cat"},
            new Animals {Id=3,Name="Dog"},
            new Animals {Id=4,Name="Donkey"}
        };

        private List<Zoo> zoo = new List<Zoo>()
        {
            new Zoo{Id=1,City="India"},
            new Zoo {Id=2,City="London"},
            new Zoo{Id=3,City="USA"},
            new Zoo{Id=4,City="Aus"}
        };
        public IActionResult Index()
        {
            AnimalZooViewData az = new AnimalZooViewData();
            az.animals = animals;
            az.Zoos = zoo;

            return View(az);
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
