using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents
{
    public class _ScriptViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
