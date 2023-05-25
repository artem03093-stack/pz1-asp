using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Practice_ASP.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public ICollection<Appliance> Appliances { get; set; } = new List<Appliance>();
    }
}
