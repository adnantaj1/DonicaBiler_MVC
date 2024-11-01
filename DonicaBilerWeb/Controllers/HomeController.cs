
using DonicaBiler.DataAccess.Data;
using DonicaBiler.Models;
using DonicaBiler.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DonicaBilerWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _db = context;
        }

        public IActionResult Index()
        {
            List<Car> objCarsList = _db.Cars.Take(6).ToList();
            return View(objCarsList);
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
