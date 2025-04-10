public class Departman
{
    public int DepartmanID { get; set; }
    public string DepartmanAdı { get; set; }

    public int FirmaID { get; set; }
    public Firma Firma { get; set; }
}