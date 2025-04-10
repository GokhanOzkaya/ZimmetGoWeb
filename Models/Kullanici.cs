public class Kullanici
{
    public int KullaniciID { get; set; }
    public string Adı { get; set; }
    public string Soyadı { get; set; }
    public string Email { get; set; }
    public string Telefon { get; set; }
    public DateTime? SonZimmetTarihi { get; set; }

    public int FirmaID { get; set; }
    public Firma Firma { get; set; }

    public int RolID { get; set; }
    public Rol Rol { get; set; }

    public ICollection<Zimmet> Zimmetler { get; set; }
    public ICollection<Log> Loglar { get; set; }
}