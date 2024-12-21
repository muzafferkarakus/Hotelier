using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents
{
    public class _PreloaderViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
