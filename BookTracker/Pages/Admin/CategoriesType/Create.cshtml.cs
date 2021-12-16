using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookTracker.Data;
using BookTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.Pages.Admin.CategoriesType
{
    public class CreateModel : PageModel
    {
        private readonly BookTracker.Data.DatabaseContext _context;

        public CreateModel(BookTracker.Data.DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CategoryType CategoryType { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (CategoryTypeExists(CategoryType.Type))
            {
                ModelState.AddModelError(string.Empty, "Type Already Exists.");
                return Page();
            }
            else {
                _context.CategoryTypes.Add(CategoryType);
                await _context.SaveChangesAsync();
            }
          
 
            return RedirectToPage("./Index");
        }


        private bool CategoryTypeExists(string id)
        {
            return _context.CategoryTypes.Any(e => e.Type == id);
        }
    }
}
