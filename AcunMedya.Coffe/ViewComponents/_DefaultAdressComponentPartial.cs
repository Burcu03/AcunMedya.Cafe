using AcunMedya.Coffe.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.ViewComponents
{
    public class _DefaultAdressComponentPartial: ViewComponent
    {
        private readonly CafeContext _context;
        public _DefaultAdressComponentPartial(CafeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
			ViewBag.OpenHours = _context.Adresses.Select(x => x.OpenHours).FirstOrDefault();
			ViewBag.Call = _context.Adresses.Select(x => x.Call).FirstOrDefault();
			return View();
        }
    }
}
