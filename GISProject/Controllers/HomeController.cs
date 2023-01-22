using GISProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace GISProject.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Map()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPoint()
        {
            Point point = new Point();
            point.longitude = Convert.ToDouble(HttpContext.Request.Form["Longitude"].ToString());
            point.latitude = Convert.ToDouble(HttpContext.Request.Form["Latitude"].ToString());
            point.title = HttpContext.Request.Form["Title"].ToString();
            point.description = HttpContext.Request.Form["Description"].ToString();
            point.UserId = HttpContext.Request.Form["UserId"].ToString();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}