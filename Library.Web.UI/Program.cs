//using LibraryMVC.Application.Abstracts;
//using LibraryMVC.Application.Concretes;
//using LibraryMVC.DataAcces.Abstracts;
//using LibraryMVC.DataAcces.Concretes.EfEntityFramework;
//using LibraryMVC.DataAcces.Context;
using Library.Web.UI.Services;
using LibraryMVC.Application.Abstracts;
using LibraryMVC.Application.Concretes;
using LibraryMVC.DataAcces.Abstracts;
using LibraryMVC.DataAcces.Concretes.EfEntityFramework;
using LibraryMVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession();//session adding
builder.Services.AddControllersWithViews();

var conn = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<LibraryDbContext>(options => options.UseSqlServer(conn));


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserDal, EfUserDal>();
builder.Services.AddScoped<IBookDal, EfBookDal>();
builder.Services.AddScoped<ICourseDal, EfCourseDal>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddSingleton<ICartSessionService,CartSessionService>();
builder.Services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
builder.Services.AddScoped<ICartService, CartService>();

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
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
