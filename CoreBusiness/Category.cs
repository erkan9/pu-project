using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Category
    {

        public int CategoryId { get; set;  }
        [Required]
        [StringLength(10, MinimumLength = 1)]
        public string Name { get; set; }
        [StringLength(30, MinimumLength = 1)]
        public string Description { get; set; }
        [StringLength(10, MinimumLength = 1)]
        public string IsLegalForEveryone { get; set; }
        [StringLength(10, MinimumLength = 1)]
        public string IsForChildren { get; set; }
        public string RecommendedAge { get; set; }

        public List<Product> Products { get; set; }
    }
}
