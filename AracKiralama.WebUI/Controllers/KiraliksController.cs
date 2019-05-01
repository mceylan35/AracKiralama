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
using AracKiralama.WebUI.KiralikServis;
using AutoMapper;

namespace AracKiralama.WebUI.Controllers
{
    public class KiraliksController : Controller
    {
        private AracKiralamaContext db = new AracKiralamaContext();
        KiralikServiceSoapClient kiralikService=new KiralikServiceSoapClient();

        // GET: Kiraliks
        public ActionResult Index()
        {
            
            var kiralik = db.Kiralik.Include(k => k.Arac).Include(k => k.Musteri);
            return View(Mapper.Map<List<Kiralik>>(kiralikService.GetAll()));
        }

        // GET: Kiraliks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kiralik kiralik = db.Kiralik.Find(id);
            if (kiralik == null)
            {
                return HttpNotFound();
            }
            return View(kiralik);
        }

        // GET: Kiraliks/Create
        public ActionResult Create()
        {
            ViewBag.AracId = new SelectList(db.Arac, "AracId", "AracAdi");
            ViewBag.MusteriId = new SelectList(db.Musteri, "MusteriId", "Adi");
            return View();
        }

        // POST: Kiraliks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KiralikId,AracId,Alis_Tarihi,Veris_Tarihi,VerilisKm,AlinanUcret,Iade,Durum,MusteriId")] Kiralik kiralik)
        {
            if (ModelState.IsValid)
            {
                db.Kiralik.Add(kiralik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AracId = new SelectList(db.Arac, "AracId", "AracAdi", kiralik.AracId);
            ViewBag.MusteriId = new SelectList(db.Musteri, "MusteriId", "Adi", kiralik.MusteriId);
            return View(kiralik);
        }

        // GET: Kiraliks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kiralik kiralik = db.Kiralik.Find(id);
            if (kiralik == null)
            {
                return HttpNotFound();
            }
            ViewBag.AracId = new SelectList(db.Arac, "AracId", "AracAdi", kiralik.AracId);
            ViewBag.MusteriId = new SelectList(db.Musteri, "MusteriId", "Adi", kiralik.MusteriId);
            return View(kiralik);
        }

        // POST: Kiraliks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KiralikId,AracId,Alis_Tarihi,Veris_Tarihi,VerilisKm,AlinanUcret,Iade,Durum,MusteriId")] Kiralik kiralik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kiralik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AracId = new SelectList(db.Arac, "AracId", "AracAdi", kiralik.AracId);
            ViewBag.MusteriId = new SelectList(db.Musteri, "MusteriId", "Adi", kiralik.MusteriId);
            return View(kiralik);
        }

        // GET: Kiraliks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kiralik kiralik = db.Kiralik.Find(id);
            if (kiralik == null)
            {
                return HttpNotFound();
            }
            return View(kiralik);
        }

        // POST: Kiraliks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kiralik kiralik = db.Kiralik.Find(id);
            db.Kiralik.Remove(kiralik);
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
