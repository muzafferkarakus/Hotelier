using Hotelier.RapidApiConsume.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotelier.RapidApiConsume.Controllers
{
    public class BookingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-126693&search_type=CITY&arrival_date=2024-12-24&departure_date=2024-12-31&adults=2&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c&currency_code=TRY"),
                Headers =
    {
        { "x-rapidapi-key", "83f88aaf35msh5bee98e575be6ebp109084jsn4c2c9f5495b9" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                return View(values.results);
            }
        }
    }
}

