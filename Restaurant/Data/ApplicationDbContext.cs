using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Data;

namespace Restaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Requisition> Requisitions { get; set; }

        public DbSet<Restaurant.Data.Menu> Menu { get; set; }

        public DbSet<Restaurant.Data.Ingredient> Ingredient { get; set; }
    }
}
