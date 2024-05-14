using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductRepository productsRepository = new ProductRepository();
            List<Product> products = productsRepository.GetAll();
            return View(products);
        }

        public ViewResult Add() { 
        return View();
        }

        [HttpPost]
        public IActionResult Add(string Name, string Description) {

            Product p = new Product {Name=Name, Description=Description };
           ProductRepository productRepository = new ProductRepository();
            productRepository.Add(p);
            return RedirectToAction("Index", "Product");
        }
    }
}
