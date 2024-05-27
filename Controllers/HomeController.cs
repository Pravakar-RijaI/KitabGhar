using KitabGhar.Data;
using KitabGhar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace KitabGhar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public IActionResult Index(string searchString)
        {
            var products = from product in _context.Products
                          select product;

            if(!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Title.Contains(searchString));
                return View(products.ToList());
            }

            //var applicationDbContext = _context.Products.Include(p => p.Category);
            return View(products.ToList());
        }

        public IActionResult ProductDetail(int productId)
        {
            var product = _context.Products.Find(productId);
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ShoppingCart(int productId)
        {
            var product = _context.Products.Find(productId);
            return View(product);
        }

        public IActionResult ShoppingSummary(int productId)
        {
            var product = _context.Products.Find(productId);
            return View(product);
        }

        public IActionResult ShoppingOrder(int productId)
        {
            var product = _context.Products.Find(productId);
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
