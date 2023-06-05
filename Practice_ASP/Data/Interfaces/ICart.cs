using Practice_ASP.Data.Models;

namespace Practice_ASP.Data.Interfaces
{
    public interface ICart
    {
        public Cart GetCart();
        public void AddItemToCart(Appliance appliance);
        public void AddCount(Appliance appliance, bool isAdd);
        public void DeleteFromCart(Appliance appliance);
        public void ClearCart();
        public Appliance GetAppliance(int id);
        public decimal TotalSum();
    }
}
