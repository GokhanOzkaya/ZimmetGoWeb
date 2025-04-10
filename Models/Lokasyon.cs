public class Lokasyon
{
    public int LokasyonID { get; set; }
    public string LokasyonAdı { get; set; }
    public string Açıklama { get; set; }

    public ICollection<Demirbas> Demirbaslar { get; set; }
}