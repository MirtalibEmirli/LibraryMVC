using System.Diagnostics;
using LibraryMVC.Application.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.UI.Controllers;

public class HomeController(IBookService bookService, IUserService userService, ICourseService courseService) : Controller
{
    private readonly IBookService _bookService = bookService;
    private readonly ICourseService _courseService = courseService;
    private readonly IUserService _userService = userService;
    public IActionResult Index()
    {

        ViewBag.UserCount = _userService.GetAll().Count;
        ViewBag.BookCount = _courseService.GetAll().Count;
        ViewBag.CourseCount = _bookService.GetAll().Count;
        return View();
    }


}
