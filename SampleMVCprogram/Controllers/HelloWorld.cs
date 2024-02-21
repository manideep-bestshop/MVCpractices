using Microsoft.AspNetCore.Mvc;

namespace SampleMVCprogram.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Manideep";
            return View();
        }
    }
}
