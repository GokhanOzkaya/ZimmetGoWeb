public class DemirbasDurumGecmisi
{
    public int DurumGecmisiID { get; set; }
    public string Durum { get; set; }
    public DateTime DegisiklikTarihi { get; set; }
    public string Notlar { get; set; }

    public int DemirbasID { get; set; }
    public Demirbas Demirbas { get; set; }
}