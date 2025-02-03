using LibraryMVC.Domain.Abstracts;

namespace LibraryMVC.Domain.Entities
{
    public class UserCourse:IEntity
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }

         
        public User User { get; set; }
        public Course Course { get; set; }
    }
}