using Library.Web.UI.Entities;
using LibraryMVC.DataAcces.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var conn = builder.Configuration.GetConnectionString("Default");
//builder.Services.AddDbContext<LibraryDbContext>(options => options.UseSqlServer(conn));
builder.Services.AddDbContext<CustomIdentityDbContext>(opt=> opt.UseSqlServer(conn));

builder.Services.AddIdentity<CustomIdentityUser, CustomUserRole>().AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();

var app = builder.Build();



if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
   
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
