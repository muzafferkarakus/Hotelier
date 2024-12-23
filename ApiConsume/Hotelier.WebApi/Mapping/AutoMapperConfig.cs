using AutoMapper;
using Hotelier.DtoLayer.Dtos.AboutDtos;
using Hotelier.DtoLayer.Dtos.BookingDtos;
using Hotelier.DtoLayer.Dtos.ContactDtos;
using Hotelier.DtoLayer.Dtos.GuestDtos;
using Hotelier.DtoLayer.Dtos.RoomDtos;
using Hotelier.DtoLayer.Dtos.SendMessageDtos;
using Hotelier.DtoLayer.Dtos.SubscribeDtos;
using Hotelier.DtoLayer.Dtos.TestimonialDtos;
using Hotelier.EntityLayer.Concrate;

namespace Hotelier.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            CreateMap<CreateRoomDto, Room>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();

            CreateMap<ResultBookingDto, Booking>().ReverseMap();
            CreateMap<UpdateBookingDto, Booking>().ReverseMap();
            CreateMap<CreateBookingDto, Booking>().ReverseMap();

            CreateMap<ResultContactDto, Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();
            CreateMap<CreateContactDto, Contact>().ReverseMap();

            CreateMap<ResultGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();
            CreateMap<CreateGuestDto, Guest>().ReverseMap();

            CreateMap<ResultSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<UpdateSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<CreateSendMessageDto, SendMessage>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
        }
    }
}
