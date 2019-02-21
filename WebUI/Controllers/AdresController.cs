using Rehber.DAL.KisiService;
using Rehber.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class AdresController : Controller
    {
        // GET: Adres
        AdresManager adm;
        KisiManager km;
        public AdresController()
        {
            adm = new AdresManager();
            km = new KisiManager();
        }
        public ActionResult Index()
        {           
            return View(adm.GetAllAdres().ToList());
        }
        [HttpGet]
        public ActionResult AdresEkle()
        {
            ViewBag.Kisilistesi = DropDownDoldur();
            return View();
        }
        public List<SelectListItem> DropDownDoldur()
        {
            List<SelectListItem> kisilistesi =
                (from a in km.GetAllKisi().ToList()
                 select new SelectListItem
                 {
                     Text = a.KisiAdi + " " + a.KisiSoyadi,
                     Value = a.KisiID.ToString()
                 }).ToList();
            return kisilistesi;
        }
        [HttpPost]
        public ActionResult AdresEkle(AdresViewModel avm)
        {
            TempData["Message"] = adm.AddAdres(new Adres
            {
                Il = avm.Il,
                Ilce = avm.Ilce,
                KisiID = avm.KisiID
            });
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdresGuncelle(int Id)
        {
            ViewBag.Kisilistesi = DropDownDoldur();
            var adres = adm.GetAllAdres(x => x.AdresID == Id).FirstOrDefault();
            AdresViewModel avm = new AdresViewModel
            {
                AdresID = adres.AdresID,
                Il = adres.Il,
                Ilce = adres.Ilce,
                KisiID = adres.KisiID             
            };
            return View(avm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdresGuncelle(AdresViewModel avm)
        {
            Adres ad = new Adres
            {
                AdresID = avm.AdresID,
                Il = avm.Il,
                Ilce = avm.Ilce,
                KisiID = avm.KisiID
            };
            TempData["Message"] = adm.UpdateAdres(ad);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdresSil(int id)
        {
            var adres = adm.GetAllAdres(x => x.AdresID == id).FirstOrDefault();           
            AdresViewModel avm = new AdresViewModel
            {
                AdresID = adres.AdresID,
                Il = adres.Il,
                Ilce = adres.Ilce,
                KisiID = adres.KisiID
            };
            var kisi = km.GetAllKisi(x => x.KisiID == avm.KisiID).FirstOrDefault();
            ViewBag.AdSoyad = kisi.KisiAdi + " " + kisi.KisiSoyadi;
            return View(avm);
        }
        [HttpPost]
        [ActionName("Adres Sil")]
        public ActionResult AdresSilinsinmi(int id)
        {
            Adres ad = adm.GetAllAdres(x => x.AdresID == id).FirstOrDefault();
            TempData["Message"] = adm.DeleteAdres(ad);
            return RedirectToAction("Index");
        }
    }
}