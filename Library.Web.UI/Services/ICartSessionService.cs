using LibraryMVC.Domain.Models;

namespace Library.Web.UI.Services;

public interface ICartSessionService
{
    Cart GetCart();
    void SetCart(Cart cart);
}
