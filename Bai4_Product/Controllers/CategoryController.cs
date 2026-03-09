using Microsoft.AspNetCore.Mvc;

namespace Bai4_Product.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            // Gia lap csdl
            var categories = new List<Models.CategoryId>
            {
                new Models.CategoryId { Id = 1, CategoryName = "Electronics" },
                new Models.CategoryId { Id = 2, CategoryName = "Books" },
                new Models.CategoryId { Id = 3, CategoryName = "Clothing" }
            };
            ViewBag.Categories = categories;

            return View(categories);
        }
    }
}
