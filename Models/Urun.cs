using System;
using System.ComponentModel.DataAnnotations;

namespace ZimmetGo.Models
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        [Display(Name = "Ürün Adı")]
        public string UrunAdi { get; set; }

        [Required(ErrorMessage = "Kategori zorunludur.")]
        [Display(Name = "Kategori")]
        public string Kategori { get; set; }

        [Required(ErrorMessage = "Seri numarası zorunludur.")]
        [Display(Name = "Seri Numarası")]
        public string SeriNumarasi { get; set; }

        [Display(Name = "Stok Durumu")]
        public bool StoktaMi { get; set; }

        [Display(Name = "Durum")]
        public string Durum { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        [Display(Name = "Alım Tarihi")]
        [DataType(DataType.Date)]
        public DateTime AlimTarihi { get; set; }

        [Display(Name = "Son Güncelleme")]
        public DateTime SonGuncelleme { get; set; }
    }
} 