using Bloggie.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bloggie.Web.Controllers
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

        public IActionResult Event()
        {
            return View();
        }
        public IActionResult Calendar(Event obj)
        {
            ViewData["events"] = new[]
            {
                //new Event{
                //    Id = obj.Id ,
                //    Title = obj.Title,
                //    StartDate = obj.StartDate
                //} 
                new Event{ Id = 1, Title = "Preparation", StartDate = "2023-09-12"},
            };
           // List<Event> events = new List<Event>();
            //events.Add(obj);
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