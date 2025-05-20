using AcunMedya.Coffe.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcunMedya.Coffe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly CafeContext _context;
        public DashboardController(CafeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            ViewBag.Message = _context.Notifications.Select(x => x.Message).FirstOrDefault();
            ViewBag.Title = _context.Notifications.Select(x => x.Title).FirstOrDefault();
            ViewBag.SenderName = _context.Notifications.Select(x => x.SenderName).FirstOrDefault();
            ViewBag.Created = _context.Notifications.Select(x => x.CreatedAt).FirstOrDefault();

            ViewBag.KategoriSayisi = _context.Categories.Count();
            ViewBag.UrunSayisi = _context.Products.Count();
            ViewBag.AboneSayisi = _context.Subscribes.Count();
            ViewBag.YorumSayisi = _context.Testimonials.Count();

            var products = _context.Products.Include(p => p.Category).ToList();
            var mostProductCategory = _context.Categories
        .Select(c => new
        {
            c.CategoryName,
            ProductCount = c.Products.Count()
        })
        .OrderByDescending(c => c.ProductCount)
        .FirstOrDefault();

            ViewBag.MostProductCategoryName = mostProductCategory?.CategoryName ?? "Kategori Bulunamadı";
            ViewBag.MostProductCategoryCount = mostProductCategory?.ProductCount ?? 0;

            var topProducts = _context.Products
        .OrderByDescending(p => p.Price)
        .Take(5)
        .Select(p => new { p.ProductName, p.Price })
        .ToList();

            ViewBag.TopProductsNames = topProducts.Select(p => p.ProductName).ToList();
            ViewBag.TopProductsPrices = topProducts.Select(p => p.Price).ToList();

            return View(products);
        }
    }
}
