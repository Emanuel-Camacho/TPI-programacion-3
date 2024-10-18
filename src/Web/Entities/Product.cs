using System.ComponentModel.DataAnnotations;

namespace Web.Entities
{
    public class Product
    {
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        public int? Id { get; set; }
        [Required]
        public int? Price { get; set; }
        [Required]
        public int? Quantity { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string? Brand { get; set; }
        [Required]    
        public int? Stock { get; set; }
        public string State { get; set; } = "Active";
    }
}
