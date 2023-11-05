using System;
using System.Collections.Generic;

namespace ExampleEntities
{
    public partial class VwSiparisTutariveAdedi
    {
        public string CustomerId { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public double? SiparişTutarı { get; set; }
        public int? SiparişSayısı { get; set; }
    }
}
