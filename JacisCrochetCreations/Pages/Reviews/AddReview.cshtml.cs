using JacisCrochetCreations.Data;
using JacisCrochetCreations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JacisCrochetCreations.Pages.Reviews
{
    public class AddReviewModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AddReviewModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Review Review { get; set; }

        [BindProperty(SupportsGet = true)]
        public int ProductId { get; set; }

        public IActionResult OnGet(int productId)
        {
            ProductId = productId;
            Review = new Review { ProductId = productId };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Reviews.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Products/Index", new { id = Review.ProductId });
        }
    }
}
