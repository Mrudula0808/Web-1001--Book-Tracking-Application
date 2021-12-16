using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTracker.Data;
using BookTracker.Models;

namespace BookTracker.Pages.Admin.Books
{
    public class DetailsModel : PageModel
    {
        private readonly BookTracker.Data.DatabaseContext _context;

        public DetailsModel(BookTracker.Data.DatabaseContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Books
                .Include(b => b.Categories).FirstOrDefaultAsync(m => m.ISBNNumber == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
