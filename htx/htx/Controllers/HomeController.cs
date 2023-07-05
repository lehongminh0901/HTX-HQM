using htx.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace htx.Controllers
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
            return View();
        }

        public IActionResult Sanpham()
        {
            return View();
        }
        public IActionResult Tin()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }

        public IActionResult Banhxeo()
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