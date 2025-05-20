using AcunMedya.Coffe.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.ViewComponents
{
	public class _DefaultFeatureComponentPartial: ViewComponent
	{
		private readonly CafeContext _context;

		public _DefaultFeatureComponentPartial(CafeContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			var value = _context.Features.ToList();
			return View(value);
		}
	}
}
