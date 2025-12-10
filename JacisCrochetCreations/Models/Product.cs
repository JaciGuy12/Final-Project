using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JacisCrochetCreations.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        [StringLength(40)]
        public string Category { get; set; }

        [Range(0, 9999)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Range(0, 999)]
        public int Stock { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}



