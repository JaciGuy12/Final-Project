using System.ComponentModel.DataAnnotations;

namespace JacisCrochetCreations.Models
{
    public class CheckoutInfo
    {
        public int CheckoutInfoId { get; set; }

        [Required, StringLength(100)]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name can only contain letters.")]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Card number must be 16 digits.")]
        public string CardNumber { get; set; }

        [Required]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/\d{2}$", ErrorMessage = "Use MM/YY format.")]
        public string ExpirationDate { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "CVV must be 3 digits.")]
        public string CVV { get; set; }
    }
}
