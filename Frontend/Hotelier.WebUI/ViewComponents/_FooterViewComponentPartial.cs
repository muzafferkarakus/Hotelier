using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents
{
    public class _FooterViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
