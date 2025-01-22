using System.ComponentModel.DataAnnotations;

namespace WebApiProduct.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string? Description { get; set; }
        public decimal Price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Stock cannot be negative")]
        public int Stock { get; set; }

    }
}
