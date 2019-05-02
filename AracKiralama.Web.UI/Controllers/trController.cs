using AracKiralama.Web.UI.MusteriServis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AracKiralama.Web.UI.Controllers
{
    public class trController : Controller
    {
        MusteriServisSoapClient musServis = new MusteriServisSoapClient();

        // GET: tr
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(string kul, string sifre)
        {
            return View();
        }

        public ActionResult Kayit()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }
    }
}