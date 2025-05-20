using AcunMedya.Coffe.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcunMedya.Coffe.ViewComponents
{
	public class _DefaultProductComponentPartial : ViewComponent
	{
		private readonly CafeContext _context;
		public _DefaultProductComponentPartial(CafeContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			//Eager Loading
			var value = _context.Products.Include(x => x.Category).ToList();
			return View(value);
		}
	}
}
