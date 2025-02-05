using LibraryMVC.Application.Abstracts;
using LibraryMVC.DataAcces.Abstracts;
using LibraryMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.Concretes;

public class CourseService(ICourseDal
     courseDal) : ICourseService
{
    private readonly ICourseDal _courseDal= courseDal; 
    public List<Course> GetAll()
    {
        var courses = _courseDal.GetList();
        return courses;
    }
}
