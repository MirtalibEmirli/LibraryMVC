using LibraryMVC.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Domain.Entities
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Mentor { get; set; }
        public string Skills { get; set; }
        public int Price { get; set; }

         public ICollection<UserCourse> UserCourses { get; set; }
    }
}
