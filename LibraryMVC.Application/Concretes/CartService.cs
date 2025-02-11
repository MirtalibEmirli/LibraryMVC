using LibraryMVC.Application.Abstracts;
using LibraryMVC.Domain.Abstracts;
using LibraryMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.Concretes;

public class CartService : ICartService
{
    public void AddToCart(Cart cart, IProductPrice item)
    {
        CartLine line = cart.CartLines.FirstOrDefault
            (c => c.Item.Id == item.Id);
        if (line == null) { cart.CartLines.Add(new CartLine { Quantity = 1, Item = item }); }
        else { line.Quantity++; }

    }

    public List<CartLine> GetAllCartItems(Cart cart)
    {
        return cart.CartLines;
    }

    public void RemoveFromCart(Cart cart, int itemId)
    {
        cart.CartLines.Remove(cart.CartLines.FirstOrDefault(cl => cl.Item.Id==itemId));
    }
}
