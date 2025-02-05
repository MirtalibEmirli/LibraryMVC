using Library.Web.UI.Entities;
using Library.Web.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.UI.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<CustomIdentityUser> _userManager;
    private readonly RoleManager<CustomUserRole> roleManager;
    private readonly SignInManager<CustomIdentityUser> signInManager;

    public AccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomUserRole> roleManager, SignInManager<CustomIdentityUser> signInManager)
    {
        _userManager = userManager;
        this.roleManager = roleManager;
        this.signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            CustomIdentityUser customIdentityUser = new CustomIdentityUser
            {
                UserName = model.UserName,
                Email = model.Email
            };
            IdentityResult identityResult = _userManager.CreateAsync(customIdentityUser, model.Password).Result;
            if (identityResult.Succeeded)
            {
                if (!roleManager.RoleExistsAsync("Admin").Result)
                {
                    CustomUserRole role = new CustomUserRole
                    {
                        Name = "Admin"
                    };
                    IdentityResult roleResult = roleManager.CreateAsync(role).Result;
                    if (!roleResult.Succeeded)
                    {
                        ModelState.AddModelError("error", "We can not add the rol");
                    }
                }
                _userManager.AddToRoleAsync(customIdentityUser, "Admin");
                return RedirectToAction("Login");

            }
        }
        return View(model);
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe,false).Result;
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Product");

            }
            ModelState.AddModelError("", "Invlaid");
        }
        return View();
    }
}



















