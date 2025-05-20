using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.ViewComponents
{
    public class _AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
