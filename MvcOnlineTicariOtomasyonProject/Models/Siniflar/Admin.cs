using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyonProject.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }


        [Display(Name = "Kullanıcı Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string KullaniciAd { get; set; }

        [Display(Name = "Şifre")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Sifre { get; set; }


        [Column(TypeName = "char")]
        [StringLength(1)]
        public string Yetki { get; set; }
    }
}