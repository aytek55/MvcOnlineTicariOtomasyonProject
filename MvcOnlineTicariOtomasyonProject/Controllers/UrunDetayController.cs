﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyonProject.Models.Siniflar;

namespace MvcOnlineTicariOtomasyonProject.Controllers
{
    [Authorize(Roles = "A")]
    public class UrunDetayController : Controller
    {
        // GET: UrunDetay

        Context c = new Context();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            //var degerler = c.Uruns.Where(x => x.UrunId == 1).ToList();

            cs.Deger1 = c.Uruns.Where(x => x.UrunId == 1).ToList();
            cs.Deger2 = c.Detays.Where(x => x.DetayID == 1).ToList();
            return View(cs);
        }
    }
}