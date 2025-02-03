using System.Diagnostics;
using Library.Web.UI.Models;
using LibraryMVC.DataAcces.Context;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.UI.Controllers
{
    public class HomeController(LibraryDbContext libraryDb) : Controller
    {
       
        public IActionResult Index()
        {
            

            return View();
        }

        
    }
}
