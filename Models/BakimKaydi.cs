using System;

namespace ZimmetGo.Models
{
    public class BakimKaydi
    {
        public int? BakimID { get; set; }  // Nullable hale getirildi
        public DateTime? BakimTarihi { get; set; }  // Nullable hale getirildi
        public string Aciklama { get; set; }  // Nullable zaten
        public string BakimDurumu { get; set; }  // Nullable zaten

        public int? DemirbasID { get; set; }  // Nullable hale getirildi
        public Demirbas Demirbas { get; set; }
    }
}