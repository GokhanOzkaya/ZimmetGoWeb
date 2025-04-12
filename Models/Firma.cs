using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZimmetGo.Models
{
    public class Firma
    {
        [Key]
        public int FirmaID { get; set; }

        [Required(ErrorMessage = "Firma adı zorunludur.")]
        [Display(Name = "Firma Adı")]
        public string FirmaAdi { get; set; }

        [Display(Name = "Adres")]
        public string Adres { get; set; }

        [Display(Name = "Telefon")]
        public string Telefon { get; set; }

        [Display(Name = "E-posta")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Display(Name = "Vergi Numarası")]
        public string VergiNo { get; set; }

        public virtual ICollection<Kullanici> Kullanicilar { get; set; }
    }
}