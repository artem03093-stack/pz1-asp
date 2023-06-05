using Microsoft.AspNetCore.Mvc;
using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Controllers
{
    public class OrderingController : Controller
    {
        private readonly ICart _cart;

        public OrderingController(ICart cart)
        {
            _cart = cart;
        }

        public IActionResult Index() => View();
        public IActionResult Checkout(Ordering model)
        {
            if (ModelState.IsValid)
            {
                _cart.ClearCart();
                return View("Confirm");
            }
            else
            {
                return View("Index", model);
            }
        }
    }
}
