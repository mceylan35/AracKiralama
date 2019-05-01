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
using AracKiralama.Web.UI.Models;
using AracKiralama.Web.UI.SirketServis;
using AutoMapper;

namespace AracKiralama.Web.UI.Controllers
{
    public class SirketsController : Controller
    {
        private AracKiralamaContext db = new AracKiralamaContext();
        SirketServisSoapClient sirketServis=new SirketServisSoapClient();

        // GET: Sirkets
        public ActionResult Index()
        {
            return View(Mapper.Map<List<SirketModel>>(sirketServis.GetAll()));
        }

        // GET: Sirkets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var sirket = Mapper.Map<SirketModel>(sirketServis.Get((int)id));
            if (sirket == null)
            {
                return HttpNotFound();
            }
            return View(sirket);
        }

        // GET: Sirkets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sirkets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SirketId,SirketAdi,Sehir,Adres,AracSayisi,SirketPuani")] SirketModel sirket)
        {
            if (ModelState.IsValid)
            {

                sirketServis.Add(new SirketDTO
                {
                    SirketAdi = sirket.SirketAdi,
                    Adres = sirket.Adres,
                    
                });
                return RedirectToAction("Index");
            }

            return View(sirket);
        }

        // GET: Sirkets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var sirket = Mapper.Map<SirketModel>(sirketServis.Get((int)id));
            if (sirket == null)
            {
                return HttpNotFound();
            }
            return View(sirket);
        }

        // POST: Sirkets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SirketId,SirketAdi,Sehir,Adres,AracSayisi,SirketPuani")] SirketModel sirket)
        {
            if (ModelState.IsValid)
            {
             //   sirketServis.Update();
                return RedirectToAction("Index");
            }

            return View(sirket);
        }

        // GET: Sirkets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var sirket = Mapper.Map<SirketModel>(sirketServis.Get((int)id));
            if (sirket == null)
            {
                return HttpNotFound();
            }
            return View(sirket);
        }

        // POST: Sirkets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sirketServis.Delete(id);
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
