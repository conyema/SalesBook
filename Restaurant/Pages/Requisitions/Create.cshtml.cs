using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant.Data;

namespace Restaurant.Pages.Requisitions
{
    public class CreateModel : PageModel
    {
        private readonly Restaurant.Data.ApplicationDbContext _context;

        public CreateModel(Restaurant.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Requisition Requisition { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Requisitions.Add(Requisition);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}