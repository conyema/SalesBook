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
    public class IndexModel : PageModel
    {
        private readonly Restaurant.Data.ApplicationDbContext _context;

        public IndexModel(Restaurant.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Menu> Menu { get;set; }

        public async Task OnGetAsync()
        {
            Menu = await _context.Menu.ToListAsync();
        }
    }
}
