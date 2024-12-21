using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents.Default
{
    public class _DefaultHeaderViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
