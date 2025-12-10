using JacisCrochetCreations.Data;
using JacisCrochetCreations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JacisCrochetCreations.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; }

        // SEARCH
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        // CATEGORY FILTER
        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        // SORTING
        public string NameSort { get; set; }
        public string PriceSort { get; set; }
        public string CategorySort { get; set; }
        public string CurrentSort { get; set; }

        // PAGINATION
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public async Task OnGetAsync(string sortOrder, int pageIndex = 1)
        {
            CurrentSort = sortOrder;

            // Sorting toggles
            NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            PriceSort = sortOrder == "price" ? "price_desc" : "price";
            CategorySort = sortOrder == "category" ? "category_desc" : "category";

            var query = _context.Products.AsQueryable();

            // CATEGORY FILTER
            if (!string.IsNullOrEmpty(Category) && Category != "All")
            {
                query = query.Where(p => p.Category == Category);
            }

            // SEARCH FILTER
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                query = query.Where(p =>
                    p.Name.Contains(SearchTerm) ||
                    p.Category.Contains(SearchTerm));
            }

            // APPLY SORTING
            query = sortOrder switch
            {
                "name_desc" => query.OrderByDescending(p => p.Name),
                "price" => query.OrderBy(p => p.Price),
                "price_desc" => query.OrderByDescending(p => p.Price),
                "category" => query.OrderBy(p => p.Category),
                "category_desc" => query.OrderByDescending(p => p.Category),
                _ => query.OrderBy(p => p.Name),
            };

            // PAGINATION SETTINGS
            int pageSize = 10;
            int count = await query.CountAsync();

            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            PageIndex = pageIndex;

            Products = await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}

