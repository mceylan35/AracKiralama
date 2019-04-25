using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracKiralama.MvcUI.KullaniciSoapService;

namespace AracKiralama.MvcUI.Controllers
{
    public class KullaniciController : Controller
    {
        KullaniciSoapServiceSoapClient kullaniciSoapService=new KullaniciSoapServiceSoapClient();
        // GET: Kullanici
        public ActionResult Index()
        {
            var kullanicilar = kullaniciSoapService.KullaniciListele();
            return View(kullanicilar);
        }
    }
}