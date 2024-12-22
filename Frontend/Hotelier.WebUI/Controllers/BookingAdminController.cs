using Hotelier.WebUI.Dtos.BookingDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using Newtonsoft.Json;
using System.Text;

namespace Hotelier.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5148/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> ApprovedReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"http://localhost:5148/api/Booking/BookingStatusChangeApproved/{id}");
            return RedirectToAction("Index", "BookingAdmin");
        }

        public async Task<IActionResult> BookingStatusChangeCancel(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"http://localhost:5148/api/Booking/BookingStatusChangeCancel/{id}");
            return RedirectToAction("Index", "BookingAdmin");
        }

        public async Task<IActionResult> BookingStatusChangeWaiting(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"http://localhost:5148/api/Booking/BookingStatusChangeWaiting/{id}");
            return RedirectToAction("Index", "BookingAdmin");
        }
    }
}
