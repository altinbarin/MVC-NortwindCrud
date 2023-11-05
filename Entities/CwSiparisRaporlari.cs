using System;
using System.Collections.Generic;

namespace ExampleEntities
{
    public partial class CwSiparisRaporlari
    {
        public int OrderId { get; set; }
        public string ÇalışanAdıVeSoyadı { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public string? ContactName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }
}
