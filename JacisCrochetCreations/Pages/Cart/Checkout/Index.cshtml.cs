using JacisCrochetCreations.Data;
using JacisCrochetCreations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace JacisCrochetCreations.Pages.Checkout
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CartItem> CartItems { get; set; }

        [BindProperty]
        public CheckoutForm Form { get; set; }

        public class CheckoutForm
        {
            [Required, MinLength(2)]
            public string Name { get; set; }

            [Required, EmailAddress]
            public string Email { get; set; }

            [Required, Phone]
            public string Phone { get; set; }

            [Required]
            [RegularExpression(@"^\d{16}$", ErrorMessage = "Card number must be 16 digits.")]
            public string CardNumber { get; set; }
        }

        public void OnGet()
        {
            CartItems = _context.CartItems
                .Include(c => c.Product)
                .ToList();
        }

        public IActionResult OnPost()
        {
            CartItems = _context.CartItems.Include(c => c.Product).ToList();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Normally you would save order to database here…

            // Clear the cart
            _context.CartItems.RemoveRange(CartItems);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Your order has been placed successfully!";

            return RedirectToPage("/Cart/Checkout/Success");
        }
    }
}

