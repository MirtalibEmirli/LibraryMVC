using LibraryMVC.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryMVC.Domain.Entities;

public partial class Book: IProductPrice
{
   

    [Required(ErrorMessage ="Add Title")]
    [Column("Title")]
    public  string? Name { get; set; }

    public string? BookImage { get; set; }
    [Required(ErrorMessage = "Add Price")]

    public int Price { get; set; }
    [Required(ErrorMessage ="Add Author")]
    public string? Author { get; set; }
    [Required(ErrorMessage = "Add Genre")]
    public string? Genre { get; set; }

    public string? Description { get; set; }

    public int Pages { get; set; }

    public int? ReadCount { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
    public int Id { get ; set ; }
}
