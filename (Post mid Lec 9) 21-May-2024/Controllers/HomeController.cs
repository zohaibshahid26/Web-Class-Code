using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication4.Models;
using WebApplication4.Models.ViewModels;
namespace WebApplication4.Controllers
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
            List<Product> products = new List<Product>();

            products.Add(new Product { Name = "Laptop" });
            products.Add(new Product { Name = "Mobile" });
            products.Add(new Product { Name = "Car" });

            Customer c = new Customer { Name = "Ali" };
            CustomerProducts cp = new CustomerProducts
            { Customer=c, Products=products };
            return View(cp);
        }

        public IActionResult Privacy()
        {
            HttpContext.Response.Cookies.Delete("first_visit");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
