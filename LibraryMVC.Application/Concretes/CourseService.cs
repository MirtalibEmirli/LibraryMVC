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
    public void Add(Course course)
    {
        _courseDal.Add(course);
    }
    public Course GetById(int id)
    {
       var c= _courseDal.Get(course=>course.Id==id);
        return  c ?? new Course() ;
    }
    public void Delete(Course course)
    {
        _courseDal.Delete(course);  
    }
    public void Update(Course course)
    {
        _courseDal.Update(course);  
    }

    public void Update(int id)
    {
        var course = _courseDal.Get(c=> c.Id==id);  
        _courseDal.Update(course);  
    }
}
