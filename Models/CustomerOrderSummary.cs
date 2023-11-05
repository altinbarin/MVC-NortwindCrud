using System;
using System.Collections.Generic;

namespace _10_MVC_NortwindCrud.Models
{
    public partial class CustomerOrderSummary
    {
        public string CustomerId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public int? ToplamSiparisSayisi { get; set; }
        public decimal? ToplamOdenenMiktar { get; set; }
    }
}
