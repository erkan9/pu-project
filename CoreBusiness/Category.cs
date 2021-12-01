using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Category
    {

        public int CategoryId { get; set;  }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string IsLegalForEveryone { get; set; }
        public string IsForChildren { get; set; }
        public string RecommendedAge { get; set; }

        public List<Product> Products { get; set; }
    }
}
