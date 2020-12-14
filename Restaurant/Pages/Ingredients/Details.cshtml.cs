using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;

namespace Restaurant.Pages.Ingredients
{
    public class DetailsModel : PageModel
    {
        private readonly Restaurant.Data.ApplicationDbContext _context;

        public DetailsModel(Restaurant.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Ingredient Ingredient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ingredient = await _context.Ingredient.FirstOrDefaultAsync(m => m.IngredientId == id);

            if (Ingredient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
