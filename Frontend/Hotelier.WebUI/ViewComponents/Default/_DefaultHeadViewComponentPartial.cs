﻿using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents.Default
{
    public class _DefaultHeadViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}