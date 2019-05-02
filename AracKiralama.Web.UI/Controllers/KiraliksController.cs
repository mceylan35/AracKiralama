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
using AracKiralama.Web.UI.AracServis;
using AracKiralama.Web.UI.KiralikServis;
using AracKiralama.Web.UI.Models;
using AracKiralama.Web.UI.MusteriServis;
//using AracKiralama.Web.UI.MusteriServis;
using AutoMapper;

namespace AracKiralama.Web.UI.Controllers
{
    public class KiraliksController : Controller
    {
        //private AracKiralamaContext db = new AracKiralamaContext();
        KiralikServiceSoapClient kiralikService=new KiralikServiceSoapClient();
        AracServisSoapClient aracServis=new AracServisSoapClient();
      MusteriServisSoapClient musteriServis=new MusteriServisSoapClient();
        
        // GET: Kiraliks
        public ActionResult Index()
        {
           // var kiralik = db.Kiralik.Include(k => k.Arac).Include(k => k.Musteri);
            
            return View(Mapper.Map<List<KiralikModel>>(kiralikService.GetAll()));
        }

        // GET: Kiraliks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var kiralik = Mapper.Map<KiralikModel>(kiralikService.Get((int)id));
            if (kiralik == null)
            {
                return HttpNotFound();
            }
            return View(kiralik);
        }

        // GET: Kiraliks/Create
        public ActionResult Create()
        {
            ViewBag.AracId = new SelectList(aracServis.GetAll(), "AracId", "AracAdi");
          ViewBag.MusteriId = new SelectList(musteriServis.GetAll(), "MusteriId", "Adi");
            return View();
        }

        // POST: Kiraliks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KiralikModel kiralik)
        {
            if (ModelState.IsValid)
            {
                kiralikService.Add(new KiralikDTO
                {
                    AlinanUcret = kiralik.AlinanUcret,
                    AracId = kiralik.AracId,
                    Alis_Tarihi = kiralik.Alis_Tarihi,
                    Veris_Tarihi = kiralik.Veris_Tarihi,
                    Durum = kiralik.Durum,
                    Iade = kiralik.Iade,
                    MusteriId = kiralik.MusteriId,
                    VerilisKm = kiralik.VerilisKm
                    
                });
                return RedirectToAction("Index");
            }
            ViewBag.AracId = new SelectList(aracServis.GetAll(), "AracId", "AracAdi", kiralik.AracId);
            ViewBag.MusteriId = new SelectList(musteriServis.GetAll(), "MusteriId", "Adi", kiralik.MusteriId);
            
            return View(kiralik);
        }

        // GET: Kiraliks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var kiralik = Mapper.Map<KiralikModel>(kiralikService.Get((int)id));
            if (kiralik == null)
            {
                return HttpNotFound();
            }
            ViewBag.AracId = new SelectList(aracServis.GetAll(), "AracId", "AracAdi", kiralik.AracId);
            ViewBag.MusteriId = new SelectList(musteriServis.GetAll(), "MusteriId", "Adi", kiralik.MusteriId);
            return View(kiralik);
        }

        // POST: Kiraliks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(KiralikModel kiralik)
        {
            if (ModelState.IsValid)
            {
               kiralikService.Update(new KiralikDTO
               {
                   KiralikId = kiralik.KiralikId,
                  // AlinanUcret = kiralik.AlinanUcret,
                   AracId = kiralik.AracId,
                   Alis_Tarihi = kiralik.Alis_Tarihi,
                   Veris_Tarihi = kiralik.Veris_Tarihi,
                   Durum = kiralik.Durum,
                   Iade = kiralik.Iade,
                   MusteriId = 1,
                   VerilisKm = kiralik.VerilisKm

               });
                return RedirectToAction("Index");
            }
            ViewBag.AracId = new SelectList(aracServis.GetAll(), "AracId", "AracAdi", kiralik.AracId);
            ViewBag.MusteriId = new SelectList(musteriServis.GetAll(), "MusteriId", "Adi", kiralik.MusteriId);
            return View(kiralik);
        }

        // GET: Kiraliks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var kiralik = Mapper.Map<KiralikModel>(kiralikService.Get((int)id));
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
            kiralikService.Delete(id);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
