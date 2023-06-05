using System.ComponentModel.DataAnnotations;

namespace Practice_ASP.Data.Models
{
    public class Ordering
    {
        [Required]
        [StringLength(50)]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(3)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(100)]
        [MinLength(5)]
        public string Address { get; set; }
        [Required]
        [MinLength(13)]
        [StringLength(13)]
        [RegularExpression(@"^\+380\d{9}$")]
        public string Mobile { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
