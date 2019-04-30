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

namespace AracKiralama.WebUI.Controllers
{
    public class KiraliksController : Controller
    {
        private AracKiralamaContext db = new AracKiralamaContext();

        // GET: Kiraliks
        public ActionResult Index()
        {
            var kiralik = db.Kiralik.Include(k => k.Arac).Include(k => k.Kullanici);
            return View(kiralik.ToList());
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
            ViewBag.AracID = new SelectList(db.Arac, "AracId", "AracAdi");
            ViewBag.KullaniciID = new SelectList(db.Kullanici, "KullaniciId", "Ad");
            return View();
        }

        // POST: Kiraliks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KiralikId,AracID,KullaniciID,Alis_Tarihi,Veris_Tarihi,VerilisKm,AlinanUcret,Iade")] Kiralik kiralik)
        {
            if (ModelState.IsValid)
            {
                db.Kiralik.Add(kiralik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AracID = new SelectList(db.Arac, "AracId", "AracAdi", kiralik.AracID);
            ViewBag.KullaniciID = new SelectList(db.Kullanici, "KullaniciId", "Ad", kiralik.KullaniciID);
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
            ViewBag.AracID = new SelectList(db.Arac, "AracId", "AracAdi", kiralik.AracID);
            ViewBag.KullaniciID = new SelectList(db.Kullanici, "KullaniciId", "Ad", kiralik.KullaniciID);
            return View(kiralik);
        }

        // POST: Kiraliks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KiralikId,AracID,KullaniciID,Alis_Tarihi,Veris_Tarihi,VerilisKm,AlinanUcret,Iade")] Kiralik kiralik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kiralik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AracID = new SelectList(db.Arac, "AracId", "AracAdi", kiralik.AracID);
            ViewBag.KullaniciID = new SelectList(db.Kullanici, "KullaniciId", "Ad", kiralik.KullaniciID);
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
