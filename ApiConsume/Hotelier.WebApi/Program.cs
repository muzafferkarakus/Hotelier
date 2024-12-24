using Hotelier.BusinessLayer.Abstract;
using Hotelier.BusinessLayer.Concrete;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Concrete;
using Hotelier.DataAccessLayer.EntityFramework;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Context>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IStaffService, StaffManager>();
builder.Services.AddScoped<IStaffDal, EfStaffDal>();

builder.Services.AddScoped<IRoomService, RoomManager>();
builder.Services.AddScoped<IRoomDal, EfRoomDal>();

builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServiceDal, EfServiceDal>();

builder.Services.AddScoped<ISubscribeService, SubscribeManager>();
builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal, EfBookingDal>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();

builder.Services.AddScoped<IGuestService, GuestManager>();
builder.Services.AddScoped<IGuestDal, EfGuestDal>();

builder.Services.AddScoped<ISendMessageService, SendMessageManager>();
builder.Services.AddScoped<ISendMessageDal, EfSendMessageDal>();

builder.Services.AddScoped<IWorkLocationService, WorkLocationManager>();
builder.Services.AddScoped<IWorkLocationDal, EfWorkLocationDal>();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("HotelierApiCors", opts =>
    {
        opts.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("HotelierApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
