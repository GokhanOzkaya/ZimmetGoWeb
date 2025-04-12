using System;

namespace ZimmetGo.Models
{
    public class DemirbasDurumGecmisi
    {
        public int? DurumGecmisiID { get; set; }  // Nullable hale getirildi
        public string Durum { get; set; }  // Nullable hale getirildi
        public DateTime? DegisiklikTarihi { get; set; }  // Nullable hale getirildi
        public string Notlar { get; set; }  // Nullable hale getirildi

        public int? DemirbasID { get; set; }  // Nullable hale getirildi
        public Demirbas Demirbas { get; set; }  // Nullable zaten
    }
}