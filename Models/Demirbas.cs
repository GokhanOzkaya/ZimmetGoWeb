public class Demirbas
{
    public int DemirbasID { get; set; }
    public string DemirbasAdı { get; set; }
    public string Açıklama { get; set; }
    public DateTime AlımTarihi { get; set; }
    public decimal Değer { get; set; }
    public string Durum { get; set; }
    public DateTime? SonZimmetTarihi { get; set; }

    public int LokasyonID { get; set; }
    public Lokasyon Lokasyon { get; set; }

    public ICollection<Zimmet> Zimmetler { get; set; }
    public ICollection<BakimKaydi> BakimKayitlari { get; set; }
    public ICollection<Resim> Resimler { get; set; }
    public ICollection<DemirbasDemirbasTuru> DemirbasTurleri { get; set; }
    public ICollection<Log> Loglar { get; set; }
    public ICollection<DemirbasDurumGecmisi> DurumGecmisi { get; set; }
}