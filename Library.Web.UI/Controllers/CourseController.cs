using LibraryMVC.Application.Abstracts;
using LibraryMVC.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.UI.Controllers;

public class CourseController(ICourseService courseService) : Controller
{
    private readonly ICourseService _courseService = courseService;
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
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var course = _courseService.GetById(id);
        return View(course);
    }
    [HttpPost]
    public IActionResult Edit(Course course, IFormFile? ImageFile)
    {
        var mainCourse = _courseService.GetById(course.Id);

        if (mainCourse == null) return NotFound();

        if (!ModelState.IsValid) return View(course);

        if (ImageFile != null) mainCourse.CourseImg = UploadImage(ImageFile);
        mainCourse.CourseLink = course.CourseLink;
        mainCourse.Name = course.Name;
        mainCourse.Duration = course.Duration;
        mainCourse.Mentor = course.Mentor;
        mainCourse.Price = course.Price;
        mainCourse.Skills = course.Skills;
        _courseService.Update(mainCourse);

        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Add(Course course, IFormFile? ImageFile)
    {
        ModelState.Remove("ImageFile");
        if (!ModelState.IsValid) return View(course);

        if (ImageFile != null)
            course.CourseImg = UploadImage(ImageFile);

        _courseService.Add(course);
        return RedirectToAction("Index");


    }

    public string UploadImage(IFormFile? ImageFile)
    {
        var extension = Path.GetExtension(ImageFile?.FileName);
        var uniqueName = $"{Guid.NewGuid()}{extension}";
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", uniqueName);

        using (var stream = new FileStream(path, FileMode.Create)) ImageFile?.CopyTo(stream);
        return "/Images/" + uniqueName;
    }
    public IActionResult Delete(int id = -1)
    {
        if (id != -1)
            _courseService.Delete(_courseService.GetById(id));
        return RedirectToAction("Index");
    }
    public IActionResult Details(int id = -2)
    {
        if (id != -2)
        {
            var course = _courseService.GetById(id);
           
                course.CourseLink = ConverToEmbedLink(course.CourseLink);
         
                return View(course);
        }
        return RedirectToAction("Index");
    }

    private string ConverToEmbedLink(string courseLink)
    {

        if (courseLink!=null&&courseLink.Contains("watch?v="))
        {
            return courseLink.Replace("watch", "embed");
        }
        return "https://www.youtube.com/embed?v=EwzWg-Joxq0&list=PLc0K4MNL-5ZykGITbZKssEyizOkH8txUn&index=2";
    }
}

