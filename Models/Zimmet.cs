using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZimmetGo.Models
{
    public class Zimmet
    {
        [Key]
        public int ZimmetID { get; set; }

        [Required]
        public int DemirbasID { get; set; }

        [Required]
        public int KullaniciID { get; set; }

        [Required(ErrorMessage = "Zimmet tarihi zorunludur.")]
        [Display(Name = "Zimmet Tarihi")]
        [DataType(DataType.Date)]
        public DateTime ZimmetTarihi { get; set; }

        [Display(Name = "İade Tarihi")]
        [DataType(DataType.Date)]
        public DateTime? IadeTarihi { get; set; }

        [Display(Name = "Durum")]
        public string Durum { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        [Display(Name = "Son Güncelleme")]
        public DateTime SonGuncelleme { get; set; }

        [ForeignKey("DemirbasID")]
        public virtual Demirbas Demirbas { get; set; }

        [ForeignKey("KullaniciID")]
        public virtual Kullanici Kullanici { get; set; }
    }
}