using System.Collections.Generic;

namespace ZimmetGo.Models
{
    public class Lokasyon
    {
        public int? LokasyonID { get; set; } // Nullable hale getirildi
        public string LokasyonAdı { get; set; } // String zaten nullable
        public string Açıklama { get; set; } // String zaten nullable

        public ICollection<Demirbas> Demirbaslar { get; set; }
    }
}