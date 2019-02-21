using Rehber.DAL.KisiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {        
        AdresManager adm;
        KisiManager km;
        // GET: Home
        public HomeController()
        {
            adm = new AdresManager();
            km = new KisiManager();
        }
        public ActionResult Index()
        {
            HomeViewModel hm = new HomeViewModel();
            hm.Kisi = km.GetAllKisi();
            hm.Adres = adm.GetAllAdres();
            return View(hm);
        }
    }
}