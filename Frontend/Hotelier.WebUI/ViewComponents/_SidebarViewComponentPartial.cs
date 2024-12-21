using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents
{
    public class _SidebarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
