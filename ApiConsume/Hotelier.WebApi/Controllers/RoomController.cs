using AutoMapper;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DtoLayer.Dtos.RoomDtos;
using Hotelier.EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateRoom(CreateRoomDto createRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(createRoomDto);
            _roomService.TInsert(values);
            return Ok("Oda Ekleme işlemi başarılı!");
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetById(id);
            _roomService.TDelete(values);
            return Ok("Oda Silindi");
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(updateRoomDto);
            _roomService.TUpdate(values);
            return Ok("Oda Güncelleme işlemi başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult RoomListById(int id)
        {
            var values = _roomService.TGetById(id);
            return Ok(values);
        }
    }
}
