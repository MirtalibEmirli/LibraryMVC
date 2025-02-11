using Library.Web.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.UI.ViewComponents
{
    public class CartSummaryViewComponent(ICartSessionService cartSessionService) : ViewComponent
    {
        private readonly ICartSessionService _sessionService = cartSessionService;
        public IViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _sessionService.GetCart()
            };
            return View(model);
        }

    }
}
