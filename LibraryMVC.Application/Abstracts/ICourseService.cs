using LibraryMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.Abstracts;

public interface ICourseService
{
   List<Course> GetAll();

    public void Add(Course course);
    public Course GetById(int id);
    public void Delete(Course course);
    public void Update(Course course);

    public void Update(int id);
    
}
