public class Rol
{
    public int RolID { get; set; }
    public string RolAdı { get; set; }
    public string Açıklama { get; set; }

    public ICollection<Kullanici> Kullanicilar { get; set; }
}