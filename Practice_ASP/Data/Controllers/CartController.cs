using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Controllers
{
    public class CartController : Controller
    {
        private readonly ICart _cart;
        private readonly IAppliance _appliance;

        public CartController(ICart cart, IAppliance appliance)
        {
            _cart = cart;
            _appliance = appliance;
        }

        [HttpPost]
        public IActionResult AddToCart(int applianceId)
        {
            var appliance = _cart.GetAppliance(applianceId);
            if(appliance == null)
            {
                var newAppliance = _appliance.GetAppliances().FirstOrDefault(i => i.Id == applianceId);
                if (newAppliance != null)
                {
                    _cart.AddItemToCart(newAppliance);
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                _cart.AddCount(appliance, true);
                return Ok();
            }
            
        }
        
        [HttpPost]
        public IActionResult RemoveFromCart(int applianceId)
        {
            var appliance = _cart.GetAppliance(applianceId);
            if(appliance != null)
            {
                _cart.DeleteFromCart(appliance);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult UpdateQuantity([FromBody] CartItem cartItem)
        {
            var appliance = _cart.GetAppliance(cartItem.ApplianceId);
            if(appliance != null)
            {
                _cart.AddCount(appliance, cartItem.IsAdd);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult ClearCart()
        {
            _cart.ClearCart();
            return Ok();
        }

        public IActionResult Index()
        {
            ViewData["TotalSum"] = _cart.TotalSum();
            return View(_cart.GetCart().Items);
        }
    }

    public record CartItem(int ApplianceId, bool IsAdd);
}
