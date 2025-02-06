using LibraryMVC.Application.Abstracts;
using LibraryMVC.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.UI.Controllers;

public class BookController(IBookService bookService) : Controller
{
    private readonly IBookService _bookService = bookService;
    public IActionResult Index()
    {
        var books = _bookService.GetAll();
        return View(books);
    }

    [HttpGet]
    public IActionResult Add()
    {
        var book = new Book();
        return View(book);
    }

    [HttpPost]
    public IActionResult Add(Book book, IFormFile? ImageFile)
    {
        ModelState.Remove("ImageFile");

        if (ModelState.IsValid)
        {
            if (ImageFile != null && ImageFile.Length > 0)
            {
                var extension = Path.GetExtension(ImageFile.FileName);
                var uniqueName = $"{Guid.NewGuid()}{extension}";
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", uniqueName);
                using (var stream = new FileStream(path, FileMode.Create))
                    ImageFile.CopyTo(stream);
                book.BookImage = "/Images/" + uniqueName;

            }
            _bookService.Add(book);
            return RedirectToAction("Index");

        }
        return RedirectToAction("Add");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var book = _bookService.GetById(id);
        return View(book);
    }


    [HttpPost]
    public IActionResult Edit(Book book, IFormFile? ImageFile)
    {

        if (ModelState.IsValid)
        {
            var mainBook = _bookService.GetById(book.Id);
            if (ImageFile != null && ImageFile.Length > 0)
            {
                var extension = Path.GetExtension(ImageFile.FileName);
                var uniqueFileName = $"{Guid.NewGuid()}{extension}";
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", uniqueFileName);

                using (var stream = new FileStream(path, FileMode.Create))
                    ImageFile.CopyTo(stream);

                mainBook.BookImage = "/Images/" + uniqueFileName;
            }
            mainBook.Author = book.Author;
            mainBook.Title = book.Title;
            mainBook.Description = book.Description;
            mainBook.Genre = book.Genre;
            mainBook.Pages = book.Pages;
            mainBook.ReadCount = book.ReadCount;
            _bookService.Update(mainBook);

            return RedirectToAction("Index");
        }

        return View(book);
    }

    public ActionResult Delete(int id)
    {

        _bookService.Delete(_bookService.GetById(id));
        return RedirectToAction("Index");

    }
    public IActionResult Details(int id) { 
    var book = _bookService.GetById(id);    
    return View(book);
    }
}
