using AracKiralama.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.Entities;
using AutoMapper;

namespace AracKiralama.SoapServis
{
    /// <summary>
    /// Summary description for KiralikService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KiralikService : System.Web.Services.WebService
    {

        private KiralikManager kiralikManager = new KiralikManager(new EfKiralikRepository());
        private AracManager aracManager = new AracManager(new EfAracRepository());

        [WebMethod]
        public void Add(KiralikDTO entity)
        {
            int gunsayisi = GunSayisiHesapla((DateTime)entity.Alis_Tarihi, (DateTime)entity.Veris_Tarihi);
            var arac = aracManager.Get((int)entity.AracId);
            decimal fiyat = KiraFiyatHesapla(gunsayisi, (decimal)arac.GunlukKiralikFiyat);
            entity.AlinanUcret = fiyat;
            var kiralik = Mapper.Map<Kiralik>(entity);
            
            
            kiralikManager.Add(kiralik);

            
        }

        private decimal KiraFiyatHesapla(int gunsayisi, decimal gunlukKiralikFiyat)
        {
            return gunsayisi * gunlukKiralikFiyat;
        }

        private int GunSayisiHesapla(DateTime alisTarihi, DateTime verisTarihi)
        {
            return Convert.ToInt32((verisTarihi - alisTarihi).TotalDays) + 1;
        }

        [WebMethod]
        public bool Delete(int id)
        {

            return kiralikManager.Delete(id);

        }

        [WebMethod]
        public KiralikDTO Get(int id)
        {
            var entity = kiralikManager.Get(id);
            return Mapper.Map<KiralikDTO>(entity);
        }
        [WebMethod]
        public List<KiralikDTO> GetAll()
        {
            var kiralikaraclar = kiralikManager.GetAll();
            return Mapper.Map<List<KiralikDTO>>(kiralikaraclar).ToList();
        }
        [WebMethod]
        public void Update(KiralikDTO entity)
        {

            var kiralik = Mapper.Map<Kiralik>(entity);

            kiralikManager.Update(kiralik);
            //nice
        }
    }
}
