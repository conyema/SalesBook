using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Data
{
    public class Requisition
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string StockId { get; set; }

        [Required]
        public string Description { get; set; }

        public string Unit { get; set; }

        public float Opening { get; set; }

        public float Issued { get; set; }

        public float Close { get; set; }
    }
}
