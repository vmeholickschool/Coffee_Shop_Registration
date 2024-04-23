// ProductController.cs
using Microsoft.AspNetCore.Mvc;
using Coffee_Shop_Registration.Models;
using System.Linq;

namespace Coffee_Shop_Registration.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}

