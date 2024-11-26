using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyonProject.Models.Siniflar
{
    public class FaturaKalem
    {
        [Key]
        public int FaturaKalemId { get; set; }

        [Display(Name = "Açıklama")]
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }

        public int Miktar { get; set; }

        [Display(Name = "Birim Fiyat")]
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }

        public int Faturaid { get; set; }
        public virtual Faturalar Faturalar { get; set; }
    }
}