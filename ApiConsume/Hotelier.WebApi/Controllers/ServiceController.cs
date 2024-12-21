using AutoMapper;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DtoLayer.Dtos.ServiceDtos;
using Hotelier.EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        private readonly IMapper _mapper;

        public ServiceController(IServiceService ServiceService, IMapper mapper)
        {
            _serviceService = ServiceService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateService(CreateServiceDto createServiceDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Service>(createServiceDto);
            _serviceService.TInsert(values);
            return Ok("Hizmet Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetById(id);
            _serviceService.TDelete(values);
            return Ok("Hizmet Silindi");
        }

        [HttpPut]
        public IActionResult UpdateService(UpdateServiceDto updateServiceDto)
        {
            var values = _mapper.Map<Service>(updateServiceDto);
            _serviceService.TUpdate(values);
            return Ok("Hizmet Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult ServiceListById(int id)
        {
            var values = _serviceService.TGetById(id);
            return Ok(values);
        }
    }
}
