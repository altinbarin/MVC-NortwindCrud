using System;
using System.Collections.Generic;

namespace _10_MVC_NortwindCrud.Models
{
    public partial class ToplamSiparisBilgisi
    {
        public int OrderId { get; set; }
        public int? ToplamSiparisMiktari { get; set; }
        public decimal? SiparisTutari { get; set; }
    }
}
