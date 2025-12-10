using System;
using System.ComponentModel.DataAnnotations;

namespace JacisCrochetCreations.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Content { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public DateTime PostedOn { get; set; } = DateTime.Now;

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}



