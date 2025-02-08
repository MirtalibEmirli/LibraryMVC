using LibraryMVC.Application.Abstracts;
using LibraryMVC.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.UI.Controllers;

public class CourseController(ICourseService courseService) : Controller
{
    private readonly ICourseService _courseService=courseService;  
    public IActionResult Index()
    {
        var courses = _courseService.GetAll();
        return View(courses);
    }

    [HttpGet]
    public IActionResult Add()
    {
        var course = new Course();
        return View(course);
    }

}

