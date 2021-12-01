using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 1)]
        public string Name { get; set; }
        [Required]
        public int? Quanity { get; set; }
        [Required]
        public double? Price { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Description { get; set; }

        public Category Category { get; set; }
    }
} 
