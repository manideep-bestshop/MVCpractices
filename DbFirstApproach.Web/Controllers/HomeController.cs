using DbFirstApproach.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DbFirstApproach.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentPortalDbContext _studentPortalDbContext;
        public HomeController(ILogger<HomeController> logger, StudentPortalDbContext studentPortalDbContext)
        {
            _logger = logger;
            _studentPortalDbContext = studentPortalDbContext;
        }

        public IActionResult Index()
        {
            var students= _studentPortalDbContext.Students.ToList();
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
