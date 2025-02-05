using Microsoft.AspNetCore.Mvc;

namespace Library.Web.UI.Controllers;

public class BookController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
