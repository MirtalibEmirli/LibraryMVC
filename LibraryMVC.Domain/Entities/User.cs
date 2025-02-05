using LibraryMVC.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryMVC.Domain.Entities;

public partial class User : IEntity
{
    public int Id { get; set; }
    [Required(ErrorMessage = "FirstName is required")]
    public string? FirstName { get; set; }
    [Required(ErrorMessage = "LastName  is required")]
    public string? LastName { get; set; }
    [Required(ErrorMessage = "Age is required")]

    public int? Age { get; set; }

    [Required(ErrorMessage = "Speciality  is required")]

    public string? Speciality { get; set; }

    public string? ProfileImageUrl { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
