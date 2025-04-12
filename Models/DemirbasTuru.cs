using System.Collections.Generic;

namespace ZimmetGo.Models
{
    public class DemirbasTuru
    {
        public int? DemirbasTuruID { get; set; }  // Nullable hale getirildi
        public string TürAdı { get; set; }  // Nullable hale getirildi
        public string Açıklama { get; set; }  // Nullable hale getirildi

        public ICollection<DemirbasDemirbasTuru> Demirbaslar { get; set; }  // Nullable zaten
    }
}