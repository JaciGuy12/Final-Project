using JacisCrochetCreations.Data;
using JacisCrochetCreations.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JacisCrochetCreations.Pages.Cart.Checkout
{
    public class ConfirmationModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ConfirmationModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CartItem> PurchasedItems { get; set; } = new();
        public decimal OrderTotal { get; set; }

        public async Task OnGetAsync()
        {
            // Load current cart items with products
            PurchasedItems = await _context.CartItems
                .Include(c => c.Product)
                .ToListAsync();

            // Calculate total
            OrderTotal = PurchasedItems.Sum(i => i.LineTotal);

            // Clear the cart after "purchase"
            if (PurchasedItems.Any())
            {
                _context.CartItems.RemoveRange(PurchasedItems);
                await _context.SaveChangesAsync();
            }
        }
    }
}



