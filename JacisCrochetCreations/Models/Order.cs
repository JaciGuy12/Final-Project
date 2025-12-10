using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JacisCrochetCreations.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required, StringLength(100)]
        public string CustomerName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [Required, StringLength(19)]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Range(0, 99999)]
        public decimal TotalAmount { get; set; }

        public List<OrderItem> Items { get; set; } = new();
    }
}
