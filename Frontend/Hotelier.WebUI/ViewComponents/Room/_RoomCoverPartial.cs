using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents.Room
{
    public class _RoomCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
