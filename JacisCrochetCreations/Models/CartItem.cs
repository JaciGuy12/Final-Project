using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JacisCrochetCreations.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Range(1, 999)]
        public int Quantity { get; set; } = 1;

        [Range(0, 9999)]
        public decimal UnitPrice { get; set; }

        public DateTime AddedAt { get; set; } = DateTime.Now;

        [NotMapped]
        public decimal LineTotal => UnitPrice * Quantity;
    }
}
