﻿using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents.Default
{
    public class _DefaultBookingViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
