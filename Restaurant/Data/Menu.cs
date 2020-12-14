using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Data
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        public string Unit { get; set; }

        public float Price { get; set; }

        public float Qty { get; set; }

        public string ImageUrl { get; set; }
    }
}
