public class Zimmet
{
    public int ZimmetID { get; set; }

    public int DemirbasID { get; set; }
    public Demirbas Demirbas { get; set; }

    public int KullaniciID { get; set; }
    public Kullanici Kullanici { get; set; }

    public DateTime ZimmetTarihi { get; set; }
    public DateTime? IadeTarihi { get; set; }
    public string Notlar { get; set; }
    public bool Aktif { get; set; }
}