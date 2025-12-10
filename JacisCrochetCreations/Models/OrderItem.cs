using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JacisCrochetCreations.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Range(1, 999)]
        public int Quantity { get; set; }

        [Range(0, 9999)]
        public decimal UnitPrice { get; set; }

        [NotMapped]
        public decimal LineTotal => UnitPrice * Quantity;
    }
}
