using LibraryMVC.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryMVC.Domain.Entities;

public partial class Course : IEntity
{
    public int Id { get; set; }
    [Required(ErrorMessage ="The Name is required")]
    public string Name { get; set; } = null!;

    public string Duration { get; set; } = null!;

    public string Mentor { get; set; } = null!;

    public string Skills { get; set; } = null!;

    public int Price { get; set; }

    public string? CourseImg { get; set; }
    public string? CourseLink { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
