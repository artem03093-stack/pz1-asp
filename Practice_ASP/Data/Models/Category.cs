namespace Practice_ASP.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Appliance> Appliances { get; set; } = new List<Appliance>();
    }
}
