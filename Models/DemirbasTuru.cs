public class DemirbasTuru
{
    public int DemirbasTuruID { get; set; }
    public string TürAdı { get; set; }
    public string Açıklama { get; set; }

    public ICollection<DemirbasDemirbasTuru> Demirbaslar { get; set; }
}