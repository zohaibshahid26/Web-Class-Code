using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            object a = ViewBag.y ;
            object b = ViewData["a"];
            object c = TempData["b"];
            return View();
        }
    }
}
