﻿using AutoMapper;
using Hotelier.EntityLayer.Concrate;
using Hotelier.WebUI.Dtos.AboutDtos;
using Hotelier.WebUI.Dtos.BookingDtos;
using Hotelier.WebUI.Dtos.LoginDto;
using Hotelier.WebUI.Dtos.RegisterDtos;
using Hotelier.WebUI.Dtos.RoomDtos;
using Hotelier.WebUI.Dtos.ServiceDtos;
using Hotelier.WebUI.Dtos.SubscribeDtos;

namespace Hotelier.WebUI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();

            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();

            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultBookingDto, Booking>().ReverseMap();
            CreateMap<UpdateBookingDto, Booking>().ReverseMap();
            CreateMap<CreateBookingDto, Booking>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
        }
    }
}