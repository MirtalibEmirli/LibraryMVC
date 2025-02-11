using LibraryMVC.Domain.Abstracts;
using LibraryMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.Abstracts;

public interface ICartService
{
    void AddToCart(Cart cart,IProductPrice item);
    void RemoveFromCart (Cart cart,int itemId); 
    List<CartLine> GetAllCartItems(Cart cart);
}
