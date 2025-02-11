using Library.Web.UI.Services;
using LibraryMVC.Application.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.UI.Controllers;

public class CartController(ICartSessionService cartSessionService ,IBookService bookService ,ICartService cartService,ICourseService courseService) : Controller
{
    private readonly ICartService _cartService = cartService;
    private readonly ICourseService _courseService = courseService;
    private readonly IBookService _bookService = bookService;
    ICartSessionService _cartSessionService = cartSessionService;

    public IActionResult AddtoCart(int id,string name)
    {
        if (name.ToLower() == "book")
        {

            var toAddedBook = _bookService.GetById(id);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, toAddedBook);
            _cartSessionService.SetCart(cart);
            TempData["message"] = $"Your Book {toAddedBook.Title} was added succeyfully to cart";

        }

        else {
            var productToAdd = _courseService.GetById(id);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToAdd);
            _cartSessionService.SetCart(cart);
            TempData["message"] = $"Your Course ,{productToAdd.Name} added to cart";
        }
        return RedirectToAction("Index", name);
    }
}
