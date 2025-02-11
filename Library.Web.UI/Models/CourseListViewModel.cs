using LibraryMVC.Domain.Entities;

namespace Library.Web.UI.Models
{
    public class CourseListViewModel
    {
        List<Course> Courses { get; set; }  
        public int PageCount { get; set; }
        public string PageName { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
    }
}
