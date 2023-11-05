using System;
using System.Collections.Generic;

namespace ExampleEntities
{
    public partial class VwOrderCustomer
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CustomerId { get; set; } = null!;
    }
}
