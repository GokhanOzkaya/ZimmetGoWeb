public class Firma
{
    public int FirmaID { get; set; }
    public string FirmaAdı { get; set; }
    public string Adres { get; set; }
    public string Telefon { get; set; }
    public string Email { get; set; }

    public ICollection<Kullanici> Kullanicilar { get; set; }
    public ICollection<Departman> Departmanlar { get; set; }
}