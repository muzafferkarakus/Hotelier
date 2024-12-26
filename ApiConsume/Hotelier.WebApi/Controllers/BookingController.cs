using AutoMapper;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DtoLayer.Dtos.BookingDtos;
using Hotelier.EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService BookingService, IMapper mapper)
        {
            _bookingService = BookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Booking>(createBookingDto);
            _bookingService.TInsert(values);
            return Ok("Rezervasyon Ekleme işlemi başarılı!");
        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok("Rezervasyon Silindi");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Booking>(updateBookingDto);
            _bookingService.TUpdate(values);
            return Ok("Rezervasyon Güncelleme işlemi başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult BookingListById(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }
        [HttpGet("BookingStatusChangeApproved/{id}")]
        public IActionResult BookingStatusChangeApproved(int id)
        {
            _bookingService.TBookingStatusChangeApproved(id);
            return Ok();
        }

        [HttpGet("BookingStatusChangeCancel/{id}")]
        public IActionResult BookingStatusChangeCancel(int id)
        {
            _bookingService.TBookingStatusChangeCancel(id);
            return Ok();
        }

        [HttpGet("BookingStatusChangeWaiting/{id}")]
        public IActionResult BookingStatusChangeWaiting(int id)
        {
            _bookingService.TBookingStatusChangeWaiting(id);
            return Ok();
        }

        [HttpGet("Last6BookingList")]
        public IActionResult Last6BookingList()
        {
            var values = _bookingService.TLast6BookingList();
            return Ok(values);
        }
    }
}


