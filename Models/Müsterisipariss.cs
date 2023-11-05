using System;
using System.Collections.Generic;

namespace _10_MVC_NortwindCrud.Models
{
    public partial class Müsterisipariss
    {
        public string CustomerId { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public int? Adet { get; set; }
        public double? Toplamtutar { get; set; }
    }
}
