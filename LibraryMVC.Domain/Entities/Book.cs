using LibraryMVC.Domain.Abstracts;
using System;
using System.Collections.Generic;

namespace LibraryMVC.Domain.Entities;

public partial class Book:IEntity
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? BookImage { get; set; }

    public string? Author { get; set; }

    public string? Genre { get; set; }

    public string? Description { get; set; }

    public int Pages { get; set; }

    public int? ReadCount { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
