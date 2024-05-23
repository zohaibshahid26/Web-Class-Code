using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Models;

namespace WebApplication5.Controllers
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
            CategoryRepository repo = new CategoryRepository();
            Category c = new Category {Id=1, Name="abcd",Description="defg" };
            repo.DeleteCategory(1);
                return View();
        }

        public IActionResult Privacy()
        {
           object o = HttpContext.Session.GetString("mydata");
            return View(o);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
