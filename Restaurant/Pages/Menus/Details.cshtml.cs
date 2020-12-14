using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;

namespace Restaurant.Pages.Menus
{
    public class DetailsModel : PageModel
    {
        private readonly Restaurant.Data.ApplicationDbContext _context;

        public DetailsModel(Restaurant.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Menu Menu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Menu = await _context.Menu.FirstOrDefaultAsync(m => m.MenuId == id);

            if (Menu == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
