using JacisCrochetCreations.Data;
using JacisCrochetCreations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JacisCrochetCreations.Pages.Cart
{
    public class AddModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AddModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int productId)
        {
            // Find the product
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
                return RedirectToPage("/Products/Index");

            // Check if item already exists in cart
            var existingItem = _context.CartItems
                .FirstOrDefault(c => c.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity += 1; // Increase quantity
            }
            else
            {
                var newItem = new CartItem
                {
                    ProductId = product.ProductId,
                    UnitPrice = product.Price,
                    Quantity = 1,
                    AddedAt = DateTime.Now
                };

                _context.CartItems.Add(newItem);
            }

            _context.SaveChanges();

            return RedirectToPage("/Products/Index");
        }
    }
}


