public class BakimKaydi
{
    public int BakimID { get; set; }
    public DateTime BakimTarihi { get; set; }
    public string Aciklama { get; set; }  // Türkçe karakterleri İngilizce'ye çevirdik
    public string BakimDurumu { get; set; }

    public int DemirbasID { get; set; }
    public Demirbas Demirbas { get; set; }
}