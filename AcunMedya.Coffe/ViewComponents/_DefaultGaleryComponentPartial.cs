using AcunMedya.Coffe.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.ViewComponents
{
    public class _DefaultGaleryComponentPartial : ViewComponent
    {
        private readonly CafeContext _context;
        public _DefaultGaleryComponentPartial(CafeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var value = _context.Galeries.ToList();
            return View(value);
        }
    }
}