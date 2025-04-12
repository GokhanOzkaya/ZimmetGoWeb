namespace ZimmetGo.Models
{
    public class Departman
    {
        public int? DepartmanID { get; set; }  // Nullable hale getirildi (isteğe bağlı)
        public string DepartmanAdı { get; set; }  // Nullable hale getirildi

        public int? FirmaID { get; set; }  // Nullable hale getirildi
        public Firma Firma { get; set; }  // Nullable zaten
    }
}