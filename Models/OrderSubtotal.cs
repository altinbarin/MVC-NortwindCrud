using System;
using System.Collections.Generic;

namespace _10_MVC_NortwindCrud.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
