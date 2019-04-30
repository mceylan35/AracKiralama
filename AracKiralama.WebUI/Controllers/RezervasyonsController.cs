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
    public class RezervasyonsController : Controller
    {
        private AracKiralamaContext db = new AracKiralamaContext();

        // GET: Rezervasyons
        public ActionResult Index()
        {
            var rezervasyon = db.Rezervasyon.Include(r => r.Arac).Include(r => r.Kullanici);
            return View(rezervasyon.ToList());
        }

        // GET: Rezervasyons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervasyon rezervasyon = db.Rezervasyon.Find(id);
            if (rezervasyon == null)
            {
                return HttpNotFound();
            }
            return View(rezervasyon);
        }

        // GET: Rezervasyons/Create
        public ActionResult Create()
        {
            ViewBag.AracId = new SelectList(db.Arac, "AracId", "AracAdi");
            ViewBag.AracId = new SelectList(db.Kullanici, "KullaniciId", "Ad");
            return View();
        }

        // POST: Rezervasyons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RezerveId,RezerveTarih,Rezerved,KullaniciId,AracId")] Rezervasyon rezervasyon)
        {
            if (ModelState.IsValid)
            {
                db.Rezervasyon.Add(rezervasyon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AracId = new SelectList(db.Arac, "AracId", "AracAdi", rezervasyon.AracId);
            ViewBag.AracId = new SelectList(db.Kullanici, "KullaniciId", "Ad", rezervasyon.AracId);
            return View(rezervasyon);
        }

        // GET: Rezervasyons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervasyon rezervasyon = db.Rezervasyon.Find(id);
            if (rezervasyon == null)
            {
                return HttpNotFound();
            }
            ViewBag.AracId = new SelectList(db.Arac, "AracId", "AracAdi", rezervasyon.AracId);
            ViewBag.AracId = new SelectList(db.Kullanici, "KullaniciId", "Ad", rezervasyon.AracId);
            return View(rezervasyon);
        }

        // POST: Rezervasyons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RezerveId,RezerveTarih,Rezerved,KullaniciId,AracId")] Rezervasyon rezervasyon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rezervasyon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AracId = new SelectList(db.Arac, "AracId", "AracAdi", rezervasyon.AracId);
            ViewBag.AracId = new SelectList(db.Kullanici, "KullaniciId", "Ad", rezervasyon.AracId);
            return View(rezervasyon);
        }

        // GET: Rezervasyons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezervasyon rezervasyon = db.Rezervasyon.Find(id);
            if (rezervasyon == null)
            {
                return HttpNotFound();
            }
            return View(rezervasyon);
        }

        // POST: Rezervasyons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rezervasyon rezervasyon = db.Rezervasyon.Find(id);
            db.Rezervasyon.Remove(rezervasyon);
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
