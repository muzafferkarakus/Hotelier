using AutoMapper;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DtoLayer.Dtos.SendMessageDtos;
using Hotelier.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;
        private readonly IMapper _mapper;

        public SendMessageController(ISendMessageService SendMessageService, IMapper mapper)
        {
            _sendMessageService = SendMessageService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendMessageService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateSendMessage(CreateSendMessageDto createSendMessageDto)
        {
            var values = _mapper.Map<SendMessage>(createSendMessageDto);
            _sendMessageService.TInsert(values);
            return Ok("Mesaj Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _sendMessageService.TGetById(id);
            _sendMessageService.TDelete(values);
            return Ok("Mesaj Silindi");
        }
        [HttpPut]
        public IActionResult UpdateSendMessage(UpdateSendMessageDto updateSendMessageDto)
        {
            var values = _mapper.Map<SendMessage>(updateSendMessageDto);
            _sendMessageService.TUpdate(values);
            return Ok("Mesaj Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult SendMessageListById(int id)
        {
            var values = _sendMessageService.TGetById(id);
            return Ok(values);
        }

        [HttpGet("GetSendMessageCount")]
        public IActionResult GetSendMessageCount()
        {
            return Ok(_sendMessageService.TGetSendMessageCount());
        }
    }
}
