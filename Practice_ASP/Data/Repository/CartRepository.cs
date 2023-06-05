using Practice_ASP.Data.Interfaces;
using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Repository
{
    public class CartRepository : ICart
    {
        private readonly Cart _cart;

        public CartRepository() 
        {
            _cart = new Cart();
        }

        public void AddCount(Appliance appliance, bool isAdd)
        {
            if (_cart.Items.ContainsKey(appliance))
            {
                if(isAdd) _cart.Items[appliance]++;
                else _cart.Items[appliance]--;
            }
        }

        public void AddItemToCart(Appliance appliance)
        {
            if (_cart.Items.ContainsKey(appliance))
            {
                _cart.Items[appliance]++;
            }
            else
            {
                _cart.Items.Add(appliance, 1);
            }
        }

        public void ClearCart()
        {
            _cart.Items.Clear();
        }

        public void DeleteFromCart(Appliance appliance)
        {
            if (_cart.Items.ContainsKey(appliance))
            {
                _cart.Items.Remove(appliance);
            }
        }

        public Appliance GetAppliance(int id) => _cart.Items.FirstOrDefault(i => i.Key.Id == id).Key;

        public Cart GetCart() => _cart;

        public decimal TotalSum() => _cart.Items.Sum(i => i.Key.Price * i.Value);
    }
}
