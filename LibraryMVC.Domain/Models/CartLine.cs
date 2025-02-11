using LibraryMVC.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Domain.Models;

public class CartLine
{
    public IProductPrice Item { get; set; }
    public int Quantity { get;set; }
}
