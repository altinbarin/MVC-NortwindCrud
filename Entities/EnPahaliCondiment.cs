using System;
using System.Collections.Generic;

namespace ExampleEntities
{
    public partial class EnPahaliCondiment
    {
        public int ProductId { get; set; }
        public string ÜrünAdı { get; set; } = null!;
        public string TedarikçiAdı { get; set; } = null!;
        public decimal? BirimFiyatı { get; set; }
    }
}
