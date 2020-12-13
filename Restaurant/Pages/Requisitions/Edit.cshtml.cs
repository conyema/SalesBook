using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;

namespace Restaurant.Pages.Requisitions
{
    public class EditModel : PageModel
    {
        private readonly Restaurant.Data.ApplicationDbContext _context;

        public EditModel(Restaurant.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Requisition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequisitionExists(Requisition.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RequisitionExists(int id)
        {
            return _context.Requisitions.Any(e => e.Id == id);
        }
    }
}
