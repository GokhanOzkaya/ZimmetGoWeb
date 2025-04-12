using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZimmetGo.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Ad zorunludur.")]
        [Display(Name = "Ad")]
        public string Adı { get; set; }

        [Required(ErrorMessage = "Soyad zorunludur.")]
        [Display(Name = "Soyad")]
        public string Soyadı { get; set; }

        [Required(ErrorMessage = "E-posta zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [Display(Name = "E-posta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }

        [Display(Name = "Telefon")]
        public string Telefon { get; set; }

        [Required]
        public int FirmaID { get; set; }

        [Required]
        public int RolID { get; set; }

        [Display(Name = "Aktif")]
        public bool Aktif { get; set; }

        public virtual Firma Firma { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual ICollection<Zimmet> Zimmetler { get; set; }
    }
}