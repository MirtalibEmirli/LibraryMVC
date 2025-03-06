using Library.Web.UI.Models;
using LibraryMVC.Application.Abstracts;
using LibraryMVC.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library.Web.UI.Controllers;

public class BookController(IBookService bookService) : Controller
{
    private readonly IBookService _bookService = bookService;

    public IActionResult Index(int page=1,string pageName="Book")
    {
        int pageSize = 4;
        
        var books = _bookService.GetAll();
        var pagedBooks= books.Skip((page - 1)*pageSize).Take(pageSize).ToList();

        var model = new BookListViewModel
        {
            PageSize = pageSize,
            PageCount = (int)Math.Ceiling(books.Count / (double)(pageSize)),
            CurrentPage = page,
            Books = pagedBooks,
            PageName = pageName
        };
        return View(model);
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

        if (!ModelState.IsValid)
            return View(book);

        if (ImageFile != null)
            book.BookImage = UploadImage(ImageFile);
        _bookService.Add(book);
        return RedirectToAction("Index");

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

        if (!ModelState.IsValid)
            return View(book);

        var mainBook = _bookService.GetById(book.Id);
        if (mainBook == null)
            return NotFound();

        if (ImageFile != null)
            mainBook.BookImage = UploadImage(ImageFile);

        mainBook.Author = book.Author;
        mainBook.Name = book.Name;
        mainBook.Description = book.Description;
        mainBook.Genre = book.Genre;
        mainBook.Pages = book.Pages;
        mainBook.ReadCount = book.ReadCount;
        _bookService.Update(mainBook);

        return RedirectToAction("Index");

    }

    public ActionResult Delete(int id)
    {
        var book = _bookService.GetById(id);
        if (book == null) return NotFound();
        _bookService.Delete(book);
        return RedirectToAction("Index");

    }
    public IActionResult Details(int id)
    {
        var book = _bookService.GetById(id);
        if (book == null)
            return NotFound();
        return View(book);
    }

    public IActionResult BooksJson()
    {
        return Json(_bookService.GetAll());
    }

    public string UploadImage(IFormFile ImageFile)
    {

        string extension = Path.GetExtension(ImageFile.FileName);
        string uniqueFileName = $"{Guid.NewGuid()}{extension}";
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", uniqueFileName);
        using (var stream = new FileStream(path, FileMode.Create))
            ImageFile.CopyTo(stream);
        return "/Images/" + uniqueFileName;


    }
}
