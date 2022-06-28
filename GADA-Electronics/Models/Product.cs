using System;
using System.Collections.Generic;

namespace GADA_Electronics.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int? CatId { get; set; }
        public int? BrandId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Category? Cat { get; set; }
    }
}
