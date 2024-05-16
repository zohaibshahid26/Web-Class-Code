using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            string c = string.Empty;
            c = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=True;";
            Category category = new Category {
            Name="Laptop", Description="Intel"};
            IRepository<Category> repo = new GenericRepository<Category>(c);
                repo.Add(category);

            return View();
        }
    }
}
