using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.ViewComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
