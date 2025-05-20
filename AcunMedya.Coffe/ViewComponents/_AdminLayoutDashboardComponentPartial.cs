using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Coffe.ViewComponents
{
    public class _AdminLayoutDashboardComponentPartial : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
