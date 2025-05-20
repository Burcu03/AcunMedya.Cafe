using AcunMedya.Coffe.Context;
using AcunMedya.Coffe.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GaleryController : Controller
    {
        private readonly CafeContext _context;

        public GaleryController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Galeries.ToList();
            return View(values);
        }

        public IActionResult AddGalery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGalery(Galery p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Galeries.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DeleteGalery(int id)
        {
            var value = _context.Galeries.Find(id);
            _context.Galeries.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateGalery(int id)
        {
            var value = _context.Galeries.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateGalery(Galery p)
        {
            _context.Galeries.Update(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
