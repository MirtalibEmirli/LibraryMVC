using LibraryMVC.Application.Abstracts;
using LibraryMVC.DataAcces.Abstracts;
using LibraryMVC.DataAcces.Concretes.EfEntityFramework;
using LibraryMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.Concretes;

public class BookService(IBookDal bookDal) : IBookService
{
    private readonly IBookDal _bookDal = bookDal;

    public List<Book> GetAll()
    {
       return _bookDal.GetList();
    }
}
