﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyonProject.Models.Siniflar
{
    public class Mesajlar
    {

        [Key]
        public int MEsajID { get; set; }


        [Display(Name = "Gönderen")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Gonderici { get; set; }

        [Display(Name = "Alıcı")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Alici { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Konu { get; set; }


        [Display(Name = "İçerik")]
        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public string icerik { get; set; }


        [Column(TypeName = "Smalldatetime")]
        public DateTime Tarih { get; set; }


    }
}