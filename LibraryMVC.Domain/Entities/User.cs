using LibraryMVC.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Domain.Entities
{
    public class User : IEntity
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string SurName { get; set; }
        public required int Age { get; set; }
        public   string Speciality { get; set; }
        public   string ProfileImageUrl { get; set; }

        public ICollection<UserBook> UserBooks { get; set; }
        public ICollection<UserCourse> UserCourses { get; set; }
    }
}
