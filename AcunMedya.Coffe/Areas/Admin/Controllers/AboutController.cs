using AcunMedya.Coffe.Context;
using AcunMedya.Coffe.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
	{
		private readonly CafeContext _context;

		public AboutController(CafeContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var values = _context.Abouts.ToList();
			return View(values);
		}

		public IActionResult AddAbout()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddAbout(About about)
		{
			if (ModelState.IsValid)
			{
				_context.Abouts.Add(about);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(about);
		}

		[HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var value = _context.Abouts.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateAbout(About about)
		{
			_context.Abouts.Update(about);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteAbout(int id)
		{
			var value = _context.Abouts.Find(id);
			if (value != null)
			{
				_context.Abouts.Remove(value);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}
