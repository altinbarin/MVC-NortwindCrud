using System;
using System.Collections.Generic;

namespace ExampleEntities
{
    public partial class KritikSeviyeUrunBilgileri
    {
        public string UrunAdi { get; set; } = null!;
        public string Kategori { get; set; } = null!;
        public string TedarikciFirma { get; set; } = null!;
        public short? MinimumSiparisAdedi { get; set; }
        public decimal? BirimFiyati { get; set; }
    }
}
