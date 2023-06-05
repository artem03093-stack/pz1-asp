namespace Practice_ASP.Data.Models
{
    public class Cart
    {
        public Dictionary<Appliance, int> Items { get; set; } = new Dictionary<Appliance, int>();
    }
}
