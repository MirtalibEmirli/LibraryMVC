using Library.Web.UI.Models;
using LibraryMVC.Application.Abstracts;
using LibraryMVC.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.UI.Controllers;

public class UserController(IUserService userService) : Controller
{
    private readonly IUserService _userService = userService;
    public IActionResult Index()
    {

        var model = _userService.GetAll();
        return View(model);
    }

    [HttpGet]
    public IActionResult Add()
    {
        var model = new UserAddViewModel
        {

            User = new User()
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult Add(UserAddViewModel userAddView, IFormFile? ProfileImageFile)
    {
        if (ModelState.IsValid)
        {
            var user = userAddView.User;
            if (ProfileImageFile != null && ProfileImageFile.Length > 0)
            {
                string fileExtension = Path.GetExtension(ProfileImageFile.FileName);
                string uniqeFileName = $"{Guid.NewGuid()}{fileExtension}";
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", uniqeFileName);

                using (var stream = new FileStream(path, FileMode.Create))
                    ProfileImageFile.CopyTo(stream);

                user.ProfileImageUrl = "/Images/" + uniqeFileName;

                Console.WriteLine("user.ProfileImageUrl: " + user.ProfileImageUrl);
            }
            _userService.Add(user);
            return RedirectToAction("Index");
        }
        return RedirectToAction("Add");
    }

    [HttpGet]
    public IActionResult Edit(int id = -1)
    {
        if (id != -1)
        {
            var user = _userService.GetById(id);
            var userEditVm = new UserEditViewModel { User = user };
            return View(userEditVm);
        }
        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult Edit(UserEditViewModel userEditViewModel, IFormFile? ProfileImageFile)

    {
        if (ModelState.IsValid)
        {
            var user = _userService.GetById(userEditViewModel.User.Id);
            if (ProfileImageFile != null && ProfileImageFile.Length > 0)
            {
                string extension = Path.GetExtension(ProfileImageFile.FileName);
                string uniqueFileName = $"{Guid.NewGuid()}{extension}";
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", uniqueFileName);
                using (var stream = new FileStream(path, FileMode.Create))
                    ProfileImageFile.CopyTo(stream);
                user.ProfileImageUrl = "/Images/" + uniqueFileName;


            }
            user.FirstName = userEditViewModel.User.FirstName;
            user.LastName = userEditViewModel.User.LastName;
            user.Age = userEditViewModel.User.Age;
            user.Speciality = userEditViewModel.User.Speciality;
            _userService.Update(user);
            return RedirectToAction("Index");
        }
        return View(userEditViewModel);
    }

 
    public IActionResult Delete(int id)
    {

        var user = _userService.GetById(id);
        _userService.Delete(user);

        return RedirectToAction("Index");





    }




}
