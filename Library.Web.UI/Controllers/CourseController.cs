using Microsoft.AspNetCore.Mvc;

namespace Library.Web.UI.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
