using FluentValidation.AspNetCore;
using Hotelier.DataAccessLayer.Concrete;
using Hotelier.EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddHttpClient();
// A�a��daki y�ntem ile t�m sayfalarda Authorize i�lemi yap�l�yor 
builder.Services.AddMvc(config =>
{
    var policy=new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build(); ;
    config.Filters.Add(new AuthorizeFilter(policy));
});

// Bu i�lem ile kullan�c�lar�n Oturum s�releri,
// Oturum a�mayan kullan�c�lar�n y�nlendirildikleri sayfa veriliyor.
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    options.LoginPath = "/Login/Index/";
});
//builder.Services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
builder.Services.AddControllersWithViews().AddFluentValidation();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404","?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
