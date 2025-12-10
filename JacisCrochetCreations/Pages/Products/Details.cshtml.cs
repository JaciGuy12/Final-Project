using JacisCrochetCreations.Data;
using JacisCrochetCreations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JacisCrochetCreations.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Product = await _context.Products
                .Include(p => p.Reviews)
                .FirstOrDefaultAsync(p => p.ProductId == id);

            if (Product == null)
                return NotFound();

            return Page();
        }
    }
}


