namespace ZimmetGo.Models
{
    public class Resim
    {
        public int? ResimID { get; set; } // Nullable hale getirildi
        public byte[] ResimVerisi { get; set; } // byte[] tipinde veri nullable olabilir
        public string Açıklama { get; set; } // String zaten nullable

        public int? DemirbasID { get; set; } // Nullable hale getirildi
        public Demirbas Demirbas { get; set; } // Navigasyon özelliği null olabilir
    }
}