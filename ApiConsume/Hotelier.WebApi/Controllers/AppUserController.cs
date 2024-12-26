using AutoMapper;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotelier.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public AppUserController(IAppUserService AppUserService, IMapper mapper)
        {
            _appUserService = AppUserService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult UserListWithWorkLocation()
        {
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorkLocationViewModel
            {
                Name = y.Name,
                Surname = y.Surname,
                WorkLocationID = y.WorkLocationId,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                City = y.City,
                Country = y.Country,
                Gender = y.Gender,
                ImageUrl = y.ImageUrl
            }).ToList();
            return Ok(values);
        }
        [HttpGet("AppUserList")]
        public IActionResult UserList()
        {
            var values = _appUserService.TGetList();
            return Ok(values);
        }
    }
}
