using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_ASP.Data.Models
{
    public class Appliance
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Precision(65, 2)]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int WarrantyInMonths { get; set; }
        [ForeignKey(nameof(Category))]
        public int IdCategory { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
        public string ImgUrl { get; set; }
    }
}
