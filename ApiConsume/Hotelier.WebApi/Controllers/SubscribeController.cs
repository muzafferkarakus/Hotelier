using AutoMapper;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DtoLayer.Dtos.SubscribeDtos;
using Hotelier.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;
        private readonly IMapper _mapper;

        public SubscribeController(ISubscribeService SubscribeService, IMapper mapper)
        {
            _subscribeService = SubscribeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateSubscribe(CreateSubscribeDto createSubscribeDto)
        {
            var values = _mapper.Map<Subscribe>(createSubscribeDto);
            _subscribeService.TInsert(values);
            return Ok("Bülten Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.TGetById(id);
            _subscribeService.TDelete(values);
            return Ok("Bülten Silindi");
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(UpdateSubscribeDto updateSubscribeDto)
        {
            var values = _mapper.Map<Subscribe>(updateSubscribeDto);
            _subscribeService.TUpdate(values);
            return Ok("Bülten Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult SubscribeListById(int id)
        {
            var values = _subscribeService.TGetById(id);
            return Ok(values);
        }
    }
}
