using System;
using System.Collections.Generic;

namespace ExampleEntities
{
    public partial class VwCustomerOrderSummary
    {
        public string CompanyName { get; set; } = null!;
        public int? SiparişAdedi { get; set; }
        public double? ToplamTutar { get; set; }
    }
}
