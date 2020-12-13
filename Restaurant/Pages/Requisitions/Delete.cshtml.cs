using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;

namespace Restaurant.Pages.Requisitions
{
    public class DeleteModel : PageModel
    {
        private readonly Restaurant.Data.ApplicationDbContext _context;

        public DeleteModel(Restaurant.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Requisition Requisition { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Requisition = await _context.Requisitions.FirstOrDefaultAsync(m => m.Id == id);

            if (Requisition == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Requisition = await _context.Requisitions.FindAsync(id);

            if (Requisition != null)
            {
                _context.Requisitions.Remove(Requisition);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
