using BulkyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BulkyBookDbContext _bulkyBookDbContext;

        public CategoryController(BulkyBookDbContext bulkyBookDbContext)
        {
            _bulkyBookDbContext = bulkyBookDbContext;
        }

        
        public IActionResult Index()
        {
            var categories = _bulkyBookDbContext.Categories.ToList();
            return View(categories);
        }
    }
}
