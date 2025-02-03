using LibraryMVC.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.UI.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    //[HttpGet]
    //public IActionResult Add()
    //{
    //    var sCities = new List<SelectListItem>();
    //    foreach (var item in cities)
    //    {
    //        sCities.Add(new SelectListItem { Text = item.Name, Value = item.AreaCode.ToString() });
    //    }

    //    var vm = new UserAddViewModel()
    //    {
    //        Cities = sCities,
    //        User = new User(),

    //    };

    //    return View(vm);
    //}

    //[HttpPost]
    //public IActionResult Add(UserAddViewModel userVM)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        var user = userVM.User;
    //        Users = ReadAllUsers();
    //        Users.Add(user);
    //        WriteAllUsers();


    //        return Redirect("/home/index");
    //    }
    //    else
    //    {
    //        var sCities = new List<SelectListItem>();
    //        foreach (var item in cities)
    //        {
    //            sCities.Add(new SelectListItem { Text = item.Name, Value = item.AreaCode.ToString() });
    //        }

    //        var vm = new UserAddViewModel()
    //        {
    //            Cities = sCities,
    //            User = new User(),

    //        };
    //        return View(vm);
    //    }






    //}


    //public IActionResult Details(Guid id)
    //{

    //    if (id != Guid.Empty)
    //    {
    //        var user = ReadByID(id);
    //        UserDTO userDTO = new UserDTO
    //        {
    //            FirstName = user.FirstName,
    //            LinkedIn = user.LinkedIn,
    //            Github = user.Github,
    //            Number = user.Number,
    //        };

    //        userDTO.City = cities.FirstOrDefault(city => city.AreaCode == user.CityId).Name;
    //        return View(userDTO);

    //    }
    //    else { ReadAllUsers(); return Json(Users); }


    //}
    //[Route("user")]
    //[Route("work")]
    //public IActionResult Render()
    //{
    //    var users = ReadAllUsers();
    //    return Json(users);
    //}
    //[HttpGet]
    //public IActionResult EditUser(Guid id)
    //{

    //    if (id != Guid.Empty)
    //    {
    //        Users = ReadAllUsers();

    //        var user = Users.FirstOrDefault(u => u.Id == id);
    //        Console.WriteLine(user.Id + " IN GET");
    //        var sCities = new List<SelectListItem>();
    //        foreach (var item in cities)
    //        {
    //            sCities.Add(new SelectListItem { Text = item.Name, Value = item.AreaCode.ToString() });

    //        }

    //        var vm = new UserEditViewModel()
    //        {
    //            Cities = sCities,
    //            User = user,
    //        };
    //        return View(vm);
    //    }
    //    else { return Redirect("/home/index"); }
    //}

    //[HttpPost]
    //public IActionResult EditUser(UserEditViewModel vm)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        var user = vm.User;
    //        Users = ReadAllUsers();


    //        var userToRemove = Users.FirstOrDefault(u => u.Id == user.Id);
    //        if (userToRemove != null)
    //        {
    //            Users.Remove(userToRemove);
    //        }


    //        Users.Add(user);

    //        WriteAllUsers();
    //    }

    //    return Redirect("/home/index");
    //}

    //public IActionResult Delete(Guid id)
    //{

    //    if (id != Guid.Empty)
    //    {
    //        Console.WriteLine(id + "deleted user id");
    //        Users = ReadAllUsers();

    //        var userToRemove = Users.FirstOrDefault(u => u.Id == id);
    //        if (userToRemove != null)
    //        {
    //            Users.Remove(userToRemove);
    //            Console.WriteLine("deleted user");

    //        }

    //        WriteAllUsers();
    //    }
    //    return Redirect("/home/index");
    //}


    //public IActionResult Back()
    //{

    //    return Redirect("/home/index");
    //}

    //public User ReadByID(Guid id)
    //{
    //    var users = ReadAllUsers();
    //    var user = users.First(u => u.Id == id);
    //    return user ?? new User();
    //}
}
