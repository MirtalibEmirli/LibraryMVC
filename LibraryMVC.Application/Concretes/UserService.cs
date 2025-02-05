using LibraryMVC.Application.Abstracts;
using LibraryMVC.DataAcces.Abstracts;
using LibraryMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.Concretes;

public class UserService(IUserDal userDal) : IUserService
{
    private readonly IUserDal _userDal = userDal;

    public void Add(User user)
    {
        _userDal.Add(user);
    }

    public List<User> GetAll()
    {
        return _userDal.GetList();

    }


    public User GetById(int id)
    {
        return _userDal.Get(u => u.Id == id);
    }

    public void Update(User user)
    {
        _userDal.Update(user);
    }

    public void Delete(User user) { _userDal.Delete(user); }    
}
