using LibraryMVC.Domain.Abstracts;

namespace LibraryMVC.Domain.Entities
{
    public class UserBook : IEntity
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int ReaderCount { get; set; }

         public User User { get; set; }
        public Book Book { get; set; }
    }
}