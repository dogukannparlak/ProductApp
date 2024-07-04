using Microsoft.AspNetCore.Mvc;
using ProductApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ProductApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductDbContext _context;

        public HomeController(ProductDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories
                .Include(c => c.SubCategories)
                .ThenInclude(sc => sc.Products)
                .ToList();

            return View(categories);
        }
    }
}
