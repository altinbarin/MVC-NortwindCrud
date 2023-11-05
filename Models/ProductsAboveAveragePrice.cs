using System;
using System.Collections.Generic;

namespace _10_MVC_NortwindCrud.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
