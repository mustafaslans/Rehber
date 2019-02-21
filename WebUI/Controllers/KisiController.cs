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
    public class KisiController : Controller
    {
        // GET: Kisi
        AdresManager adm;
        KisiManager km;
        public KisiController()
        {
            adm = new AdresManager();
            km = new KisiManager();
        }
        public ActionResult Index()
        {
            return View(km.GetAllKisi().ToList());
        }
        [HttpGet]
        public ActionResult KisiEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KisiEkle(KisiViewModel kvm)
        {
            string mesaj = km.AddKisi(new Kisi { KisiAdi = kvm.KisiAdi, KisiSoyadi = kvm.KisiSoyadi, KisiYas = kvm.KisiYas });
            TempData["Message"] = mesaj;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult KisiGuncelle(int Id)
        {
            var kisi = km.GetAllKisi(x => x.KisiID == Id).FirstOrDefault();
            KisiViewModel kvm = new KisiViewModel
            {
                KisiID = kisi.KisiID,
                KisiAdi = kisi.KisiAdi,
                KisiSoyadi = kisi.KisiSoyadi,
                KisiYas = kisi.KisiYas
            };
            return View(kvm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KisiGuncelle(KisiViewModel kvm)
        {
            Kisi ad = new Kisi
            {
                KisiID = kvm.KisiID,
                KisiAdi = kvm.KisiAdi,
                KisiSoyadi = kvm.KisiSoyadi,
                KisiYas = kvm.KisiYas
            };
            TempData["Message"] = km.UpdateKisi(ad);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult KisiSil(int id)
        {
            var kisi = km.GetAllKisi(x => x.KisiID == id).FirstOrDefault();
            KisiViewModel kvm = new KisiViewModel
            {
                KisiID = kisi.KisiID,
                KisiAdi = kisi.KisiAdi,
                KisiSoyadi = kisi.KisiSoyadi,
                KisiYas = kisi.KisiYas
            };
            return View(kvm);
        }
        [HttpPost]
        [ActionName("Adres Sil")]
        public ActionResult KisiSilinsinmi(int id)
        {
            Kisi ad = km.GetAllKisi(x => x.KisiID == id).FirstOrDefault();
            TempData["Message"] = km.DeleteKisi(ad);
            return RedirectToAction("Index");
        }
    }
}