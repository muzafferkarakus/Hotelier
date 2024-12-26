using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var staffCount = await client.GetAsync("http://localhost:5148/api/DashboardWidgets/StaffCount");
            var bookingCount = await client.GetAsync("http://localhost:5148/api/DashboardWidgets/BookingCount");
            var guestCount = await client.GetAsync("http://localhost:5148/api/DashboardWidgets/GuestCount");
            var roomCount = await client.GetAsync("http://localhost:5148/api/DashboardWidgets/RoomCount");
            
            var staffData = await staffCount.Content.ReadAsStringAsync();
            var bookingData = await bookingCount.Content.ReadAsStringAsync();
            var guestData = await guestCount.Content.ReadAsStringAsync();
            var roomData = await roomCount.Content.ReadAsStringAsync();
            
            ViewBag.staffCount = staffData;
            ViewBag.bookingCount = bookingData;
            ViewBag.guestCount = guestData;
            ViewBag.roomCount = roomData;

            return View();
        }
    }
}
