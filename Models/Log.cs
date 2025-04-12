using System;

namespace ZimmetGo.Models
{
    public class Log
    {
        public int? LogID { get; set; } // Nullable hale getirildi

        public int? DemirbasID { get; set; } // Nullable hale getirildi
        public Demirbas Demirbas { get; set; }

        public int? KullaniciID { get; set; } // Nullable hale getirildi
        public Kullanici Kullanici { get; set; }

        public DateTime? IslemTarihi { get; set; } // Nullable DateTime
        public string IslemTipi { get; set; } // String zaten nullable
        public string Notlar { get; set; } // String zaten nullable
    }
}