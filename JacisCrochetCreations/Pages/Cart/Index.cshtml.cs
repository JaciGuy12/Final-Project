using JacisCrochetCreations.Data;
using JacisCrochetCreations.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JacisCrochetCreations.Pages.Cart
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CartItem> CartItems { get; set; }

        public decimal Total => CartItems.Sum(i => i.UnitPrice * i.Quantity);

        public async Task OnGetAsync()
        {
            CartItems = await _context.CartItems
                .Include(c => c.Product)
                .ToListAsync();
        }
    }
}
