public class Log
{
    public int LogID { get; set; }

    public int DemirbasID { get; set; }
    public Demirbas Demirbas { get; set; }

    public int KullaniciID { get; set; }
    public Kullanici Kullanici { get; set; }

    public DateTime IslemTarihi { get; set; }
    public string IslemTipi { get; set; }
    public string Notlar { get; set; }
}