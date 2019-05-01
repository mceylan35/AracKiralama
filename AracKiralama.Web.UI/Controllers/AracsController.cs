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
using AracKiralama.Web.UI.Models;
using AutoMapper;

namespace AracKiralama.Web.UI.Controllers
{
    public class AracsController : Controller
    {
        private AracKiralamaContext db = new AracKiralamaContext();

        AracServisSoapClient aracServis = new AracServisSoapClient();
        // GET: Aracs
        public ActionResult Index()
        {
            //return View(Mapper.Map<List<AracDTO>>(aracServis.GetAll()));
            return View(Mapper.Map<List<AracModel>>(aracServis.GetAll()));
        }

        // GET: Aracs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var arac = Mapper.Map<AracModel>(aracServis.Get((int)id));
            if (arac == null)
            {
                return HttpNotFound();
            }
            return View(arac);
        }

        // GET: Aracs/Create
        public ActionResult Create()
        {
           // ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi");
            return View();
        }

        // POST: Aracs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AracId,AracAdi,Model,EhliyetYasi,MinYasSiniri,GunlukSinirKM,KendiAnlikKM,AirBag,BagajHacmi,KoltukSayisi,GunlukKiralikFiyat,Rezerve,Resim")] AracModel arac)
        {
            if (ModelState.IsValid)
            {
                arac.SirketId = 1;
                aracServis.Add(Mapper.Map<AracDTO>(arac));
                return RedirectToAction("Index");
            }

           
            return View(arac);
        }

        // GET: Aracs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var arac = Mapper.Map<AracModel>(aracServis.Get((int)id));
            if (arac == null)
            {
                return HttpNotFound();
            }
        //    ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi", arac.SirketId);
            return View(arac);
        }

        // POST: Aracs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AracModel arac)
        {
            if (ModelState.IsValid)
            {
               // var aracedit = Mapper.Map<AracDTO>(arac);
               
                aracServis.Update(new AracDTO
                {
                    AracAdi = arac.AracAdi,
                    AracId = arac.AracId,
                    BagajHacmi = arac.BagajHacmi,
                    AirBag = arac.AirBag,
                    EhliyetYasi = arac.EhliyetYasi,
                    KendiAnlikKM = arac.KendiAnlikKM,
                    GunlukKiralikFiyat = arac.GunlukKiralikFiyat,
                    KoltukSayisi = arac.KoltukSayisi,
                    MinYasSiniri = arac.MinYasSiniri,
                    GunlukSinirKM = arac.GunlukSinirKM,
                   Model = arac.Model
                    
                });
                return RedirectToAction("Index");
            }
          //  ViewBag.SirketId = new SelectList(db.Sirket, "SirketId", "SirketAdi", arac.SirketId);
            return View(arac);
        }

        // GET: Aracs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var arac = Mapper.Map<AracModel>(aracServis.Get((int)id));
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
        
            try
            {
           //     var arac = Mapper.Map<AracModel>(aracServis.Get((int)id));
                aracServis.Delete(id);
              
             
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {

            
                return View();
            }

            
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
