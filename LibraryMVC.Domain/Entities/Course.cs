using LibraryMVC.Domain.Abstracts;
using System;
using System.Collections.Generic;

namespace LibraryMVC.Domain.Entities;

public partial class Course : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Duration { get; set; } = null!;

    public string Mentor { get; set; } = null!;

    public string Skills { get; set; } = null!;

    public int Price { get; set; }

    public string? CourseImg { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
