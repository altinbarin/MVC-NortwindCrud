using System;
using System.Collections.Generic;

namespace _10_MVC_NortwindCrud.Models
{
    public partial class Top5Condiment
    {
        public int ProductId { get; set; }
        public string ÜrünAdı { get; set; } = null!;
        public string? TedarikçiAdı { get; set; }
        public decimal? ÜrünFiyatı { get; set; }
    }
}
