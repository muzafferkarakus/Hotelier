using AutoMapper;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DtoLayer.Dtos.WorkLocationDtos;
using Hotelier.EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;
        private readonly IMapper _mapper;

        public WorkLocationController(IWorkLocationService WorkLocationService, IMapper mapper)
        {
            _workLocationService = WorkLocationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult WorkLocationList()
        {
            var values = _workLocationService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateWorkLocation(CreateWorkLocationDto createWorkLocationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<WorkLocation>(createWorkLocationDto);
            _workLocationService.TInsert(values);
            return Ok("Personel Lokasyon Ekleme başarılı!");
        }

        [HttpDelete]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _workLocationService.TGetById(id);
            _workLocationService.TDelete(values);
            return Ok("Personel Lokasyon Silindi");
        }

        [HttpPut]
        public IActionResult UpdateWorkLocation(UpdateWorkLocationDto updateWorkLocationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<WorkLocation>(updateWorkLocationDto);
            _workLocationService.TUpdate(values);
            return Ok("Personel Lokasyon Güncelleme işlemi başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult WorkLocationListById(int id)
        {
            var values = _workLocationService.TGetById(id);
            return Ok(values);
        }
    }
}
