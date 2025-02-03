using LibraryMVC.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Domain.Entities
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BookImage { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public int ReadCount { get; set; }

          
        public ICollection<UserBook> UserBooks { get; set; }
    }
}
