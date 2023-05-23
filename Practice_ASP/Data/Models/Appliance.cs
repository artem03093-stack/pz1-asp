namespace Practice_ASP.Data.Models
{
    public class Appliance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int WarrantyInMonths { get; set; }
        public int IdCategory { get; set; }
    }
}
