using System;
using System.Collections.Generic;

namespace ExampleEntities
{
    public partial class VwCalisanBilgileri
    {
        public string FirstName { get; set; } = null!;
        public DateTime? HireDate { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
