using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Data
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        [Required]
        public int MenuId { get; set; }

        [Required]
        public string SKU { get; set; }

        public string Description { get; set; }

        public string Unit { get; set; }

        public float Qty { get; set; }

        public int Servings { get; set; }
    }
}
