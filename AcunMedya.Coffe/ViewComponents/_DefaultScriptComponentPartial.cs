using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.ViewComponents
{
	public class _DefaultScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
