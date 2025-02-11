using LibraryMVC.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Domain.Models;

public class Cart
{
    public List<CartLine> CartLines { get; set; }
    public Cart()
    {
        CartLines = [];
    }
    public int Total
    {
        get
        {
            return CartLines.Sum(c => (c.Item)?.Price * c.Quantity ?? 0);
        }
    }
}
