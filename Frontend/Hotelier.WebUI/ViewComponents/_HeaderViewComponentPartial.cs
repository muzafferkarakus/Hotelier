using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents
{
    public class _HeaderViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
