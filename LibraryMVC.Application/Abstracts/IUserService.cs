﻿using LibraryMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.Abstracts;

public interface IUserService
{
    public List<User> GetAll();
    public User GetById(int id);    
    public void Add(User user); 
    public void Update(User user); 
    public void Delete(User user);
}
