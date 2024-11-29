﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyonProject.Models.Siniflar;

namespace MvcOnlineTicariOtomasyonProject.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori

        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Kategoris.ToList();
            return View(degerler);
        }

        [HttpGet]//form yüklendigi zaman bu kısım calısması için gereken metot
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]//bir butona tıklanınca çalısacak
        public ActionResult KategoriEkle(Kategori k)
        {
            c.Kategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var Silinecek_ktg = c.Kategoris.Find(id);
            c.Kategoris.Remove(Silinecek_ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Kategoris.Find(id);
            return View("KategoriGetir", kategori);
        }

        public ActionResult KategoriGuncelle(Kategori k)
        {
            var kategori = c.Kategoris.Find(k.KategoriID);
            kategori.KategoriAd = k.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        //public ActionResult deneme()
        //{
        //    Class3 cs = new Class3();
        //    cs.Kategoriler = new SelectList(c.Kategoris, "KategoriID", "KategoriAd");
        //    cs.Urunler = new SelectList(c.Uruns, "UrunId", "UrunAd");
        //    return View(cs);
        //}
        //public JsonResult UrunGetir(int p)
        //{
        //    var urunlistesi = (from x in c.Uruns
        //                       join y in c.Kategoris
        //                       on x.Kategori.KategoriID equals y.KategoriID
        //                       where x.Kategori.KategoriID == p
        //                       select new
        //                       {
        //                           Text = x.UrunAd,
        //                           Value = x.UrunId.ToString()
        //                       }).ToList();
        //    return Json(urunlistesi, JsonRequestBehavior.AllowGet);
        //}
    }
}