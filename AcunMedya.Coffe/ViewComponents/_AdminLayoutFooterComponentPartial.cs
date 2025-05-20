using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.ViewComponents
{
    public class _AdminLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
