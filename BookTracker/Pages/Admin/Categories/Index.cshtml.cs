using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTracker.Data;
using BookTracker.Models;

namespace BookTracker.Pages.Admin.Categories
{
    public class IndexModel : PageModel
    {
        private readonly BookTracker.Data.DatabaseContext _context;

        public IndexModel(BookTracker.Data.DatabaseContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Categories
                .Include(c => c.Type).ToListAsync();
        }
    }
}
