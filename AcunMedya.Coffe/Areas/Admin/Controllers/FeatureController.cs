using AcunMedya.Coffe.Context;
using AcunMedya.Coffe.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureController : Controller
    {
        private readonly CafeContext _context;

        public FeatureController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var features = _context.Features.ToList();
            return View(features);
        }

        public IActionResult AddFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFeature(Feature p)
        {
            if (ModelState.IsValid)
            {
                _context.Features.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(p);
        }

        public IActionResult UpdateFeature(int id)
        {
            var feature = _context.Features.Find(id);
            if (feature == null)
            {
                return RedirectToAction("Index");
            }

            return View(feature);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature p)
        {
            if (ModelState.IsValid)
            {
                _context.Features.Update(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(p);
        }

        public IActionResult DeleteFeature(int id)
        {
            var feature = _context.Features.Find(id);
            if (feature != null)
            {
                _context.Features.Remove(feature);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
