namespace ZimmetGo.Models
{
    public class DemirbasDemirbasTuru
    {
        public int? DemirbasID { get; set; }  // Nullable hale getirildi
        public Demirbas Demirbas { get; set; }  // Nullable zaten

        public int? DemirbasTuruID { get; set; }  // Nullable hale getirildi
        public DemirbasTuru DemirbasTuru { get; set; }  // Nullable zaten
    }
}