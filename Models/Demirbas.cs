using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZimmetGo.Models
{
    public class Demirbas
    {
        [Key]
        public int DemirbasID { get; set; }

        [Required(ErrorMessage = "Demirbaş adı zorunludur.")]
        [Display(Name = "Demirbaş Adı")]
        public string DemirbasAdi { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        [Display(Name = "Alım Tarihi")]
        [DataType(DataType.Date)]
        public DateTime AlimTarihi { get; set; }

        [Display(Name = "Değer")]
        [DataType(DataType.Currency)]
        public decimal Deger { get; set; }

        [Display(Name = "Durum")]
        public string Durum { get; set; }

        [Display(Name = "Son Zimmet Tarihi")]
        [DataType(DataType.Date)]
        public DateTime? SonZimmetTarihi { get; set; }

        [Required]
        public int LokasyonID { get; set; }

        public virtual Lokasyon Lokasyon { get; set; }
        public virtual ICollection<Zimmet> Zimmetler { get; set; }
        public virtual ICollection<BakimKaydi> BakimKayitlari { get; set; }
        public virtual ICollection<Resim> Resimler { get; set; }
        public virtual ICollection<DemirbasDemirbasTuru> DemirbasTurleri { get; set; }
        public virtual ICollection<Log> Loglar { get; set; }
        public virtual ICollection<DemirbasDurumGecmisi> DurumGecmisi { get; set; }
    }
}