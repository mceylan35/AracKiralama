using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AracKiralama.Dal.Concrete.EntityFramework.Context;
using AracKiralama.Entities;
using AracKiralama.WebUI.AracServis;
using AracKiralama.WebUI.KiralikServis;
using AracKiralama.WebUI.Models;
using AracKiralama.WebUI.SirketServis;
using AutoMapper;

namespace AracKiralama.WebUI.Controllers
{
    public class AracsController : Controller
    {
        AracServisSoapClient aracServis=new AracServisSoapClient();
        private AracKiralamaContext db = new AracKiralamaContext();
        KiralikServiceSoapClient kiralikService=new KiralikServiceSoapClient();

        SirketServisSoapClient sirketServis=new SirketServisSoapClient();

        // GET: Aracs
        //public ActionResult Index()
        //{
        //    var kiraliklar = Mapper.Map<List<Kiralik>>(kiralikService.GetAll().ToList());
        //    List<Kiralik> kiraliste=new List<Kiralik>();

        //    foreach (var kiralik in kiraliste)
        //    {
        //        Kiralik kira = new Kiralik()
        //        {
        //            Arac = kiralik.Arac,
        //            KiralikId = kiralik.KiralikId,
        //            AracId = kiralik.AracId,
        //            AlinanUcret = kiralik.AlinanUcret,
        //            Alis_Tarihi = kiralik.Alis_Tarihi,
        //            Veris_Tarihi = kiralik.Veris_Tarihi,
        //            Durum = kiralik.Durum,
        //            Iade = kiralik.Iade,
        //            Musteri = null,
        //            MusteriId = null
        //        };
        //        kiraliste.Add(kira);
        //    }

        //    var sirket = Mapper.Map<Sirket>(sirketServis.Get(1));

        // //   var arac = db.Arac.Include(a => a.Sirket);
        //   var araclar= Mapper.Map<List<Arac>>(aracServis.GetAll().ToList());
        //    List<Arac> araclarliste=new List<Arac>();
        //    foreach (var arac1 in araclar)
        //    {


        //        Arac ar = new Arac
        //        {
        //            AracAdi = arac1.AracAdi,
        //            AirBag = arac1.AirBag,
        //            AracId = arac1.AracId,
        //            BagajHacmi = arac1.BagajHacmi,
        //            EhliyetYasi = arac1.EhliyetYasi,
        //            GunlukKiralikFiyat = arac1.GunlukKiralikFiyat,
        //            GunlukSinirKM = arac1.GunlukSinirKM,
        //            KendiAnlikKM = arac1.KendiAnlikKM,
        //            Kiralik =kiraliste,
        //            KoltukSayisi = arac1.KoltukSayisi,
        //            SirketId = arac1.SirketId,
        //            Sirket = sirket


        //        };
        //            araclarliste.Add(ar);
        //    }
        //    return View(araclarliste);
        //}

        public ActionResult Index()
        {
           var liste= Mapper.Map<List<AracModel>>(aracServis.GetAll());
            return View(liste);
        }

        // GET: Aracs/Details/5
            public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arac arac = db.Arac.Find(id);
            if (arac == null)
            {
                return HttpNotFound();
            }
            return View(arac);
        }

        // GET: Aracs/Create
        public ActionResult Create()
        {
            ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi");
            return View();
        }

        // POST: Aracs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AracId,AracAdi,Model,EhliyetYasi,MinYasSiniri,GunlukSinirKM,KendiAnlikKM,AirBag,BagajHacmi,KoltukSayisi,GunlukKiralikFiyat,SirketId,Rezerve,Resim")] Arac arac)
        {
            if (ModelState.IsValid)
            {
                db.Arac.Add(arac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi", arac.SirketId);
            return View(arac);
        }

        // GET: Aracs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arac arac = db.Arac.Find(id);
            if (arac == null)
            {
                return HttpNotFound();
            }
            ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi", arac.SirketId);
            return View(arac);
        }

        // POST: Aracs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AracId,AracAdi,Model,EhliyetYasi,MinYasSiniri,GunlukSinirKM,KendiAnlikKM,AirBag,BagajHacmi,KoltukSayisi,GunlukKiralikFiyat,SirketId,Rezerve,Resim")] Arac arac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi", arac.SirketId);
            return View(arac);
        }

        // GET: Aracs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arac arac = db.Arac.Find(id);
            if (arac == null)
            {
                return HttpNotFound();
            }
            return View(arac);
        }

        // POST: Aracs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arac arac = db.Arac.Find(id);
            db.Arac.Remove(arac);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
