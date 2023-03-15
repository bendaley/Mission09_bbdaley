using Microsoft.AspNetCore.Mvc;
using Mission09_bbdaley.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Mission09_bbdaley.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        // private Cart cart;
        private Basket basket;
        // public CartSummaryViewComponent(Cart cartService)
        public CartSummaryViewComponent(Basket basketService)
        {
            // cart = cartService;
            basket = basketService;
        }
        public IViewComponentResult Invoke()
        {
            // return View(cart);
            return View(basket);
        }
    }
}
