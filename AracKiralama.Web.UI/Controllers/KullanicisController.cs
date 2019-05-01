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
using AracKiralama.Web.UI.KullaniciServis;
using AracKiralama.Web.UI.Models;
using AutoMapper;

namespace AracKiralama.Web.UI.Controllers
{
    public class KullanicisController : Controller
    {
        private AracKiralamaContext db = new AracKiralamaContext();

        KullaniciServisSoapClient  kullaniciServis = new KullaniciServisSoapClient();

        // GET: Kullanicis
        public ActionResult Index()
        {
            var kullanicilar = Mapper.Map<List<KullaniciModel>>(kullaniciServis.GetAll());
            return View(kullanicilar);
        }
        
        // GET: Kullanicis/Details/5e
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = db.Kullanici.Find(id);
            if (kullanici == null)
            {
                return HttpNotFound();
            }
            return View(kullanici);
        }

        // GET: Kullanicis/Create
        public ActionResult Create()
        {
            ViewBag.RoleId = new SelectList(db.Role, "RoleId", "Role1");
            ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi");
            return View();
        }

        // POST: Kullanicis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KullaniciId,Ad,Soyad,Email,EhliyetAlimTarihi,Sifre,DogumTarihi,RoleId,SirketId")] Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                db.Kullanici.Add(kullanici);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RoleId = new SelectList(db.Role, "RoleId", "Role1", kullanici.RoleId);
            ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi", kullanici.SirketId);
            return View(kullanici);
        }

        // GET: Kullanicis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = db.Kullanici.Find(id);
            if (kullanici == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoleId = new SelectList(db.Role, "RoleId", "Role1", kullanici.RoleId);
            ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi", kullanici.SirketId);
            return View(kullanici);
        }

        // POST: Kullanicis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KullaniciId,Ad,Soyad,Email,EhliyetAlimTarihi,Sifre,DogumTarihi,RoleId,SirketId")] Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kullanici).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RoleId = new SelectList(db.Role, "RoleId", "Role1", kullanici.RoleId);
            ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi", kullanici.SirketId);
            return View(kullanici);
        }

        // GET: Kullanicis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = db.Kullanici.Find(id);
            if (kullanici == null)
            {
                return HttpNotFound();
            }
            return View(kullanici);
        }

        // POST: Kullanicis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kullanici kullanici = db.Kullanici.Find(id);
            db.Kullanici.Remove(kullanici);
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
