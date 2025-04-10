public class Resim
{
    public int ResimID { get; set; }
    public byte[] ResimVerisi { get; set; }
    public string Açıklama { get; set; }

    public int DemirbasID { get; set; }
    public Demirbas Demirbas { get; set; }
}