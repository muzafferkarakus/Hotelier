using AutoMapper;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DtoLayer.Dtos.StaffDtos;
using Hotelier.EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;

        public StaffController(IStaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateStaff(CreateStaffDto createStaffDto)
        {
            var values = _mapper.Map<Staff>(createStaffDto);
            _staffService.TInsert(values);
            return Ok("Personel Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.TGetById(id);
            _staffService.TDelete(values);
            return Ok("Personel Silindi");
        }
        [HttpPut]
        public IActionResult UpdateStaff(UpdateStaffDto updateStaffDto)
        {
            var values = _mapper.Map<Staff>(updateStaffDto);
            _staffService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult StaffListById(int id)
        {
            var values = _staffService.TGetById(id);
            return Ok(values);
        }
    }
}
