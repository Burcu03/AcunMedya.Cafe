using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.ViewComponents
{
	public class _DefaultHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
