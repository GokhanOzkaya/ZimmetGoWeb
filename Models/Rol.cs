using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZimmetGo.Models
{
    public class Rol
    {
        [Key]
        public int RolID { get; set; }

        [Required(ErrorMessage = "Rol adı zorunludur.")]
        [Display(Name = "Rol Adı")]
        public string RolAdi { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        public virtual ICollection<Kullanici> Kullanicilar { get; set; }
    }
}