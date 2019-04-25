using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.DTO.DTO;
using AracKiralama.Entities;
using AracKiralama.Interfaces;

namespace AracKiralama.SOAP
{
    /// <summary>
    /// Summary description for KiralikSoapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KiralikSoapService : System.Web.Services.WebService
    {
        private KiralikManager kiralikManager = new KiralikManager(new EfKiralikRepository());
        private AracManager aracManager = new AracManager(new EfAracRepository());

        [WebMethod]
        public void Add(KiralikDTO entity)
        {
            int gunsayisi = GunSayisiHesapla((DateTime)entity.Alis_Tarihi,(DateTime)entity.Veris_Tarihi);
            var arac = aracManager.Get((int) entity.AracID);
            decimal fiyat = gunsayisi * (decimal)arac.GunlukKiralikFiyat;
        
            kiralikManager.Add(new Kiralik
            {
                KiralikId = entity.KiralikId,
                KullaniciID = entity.KullaniciID,
                AracID = entity.AracID,
                Alis_Tarihi = entity.Alis_Tarihi,
                VerilisKm = entity.VerilisKm,
                Veris_Tarihi = entity.Veris_Tarihi,
                Iade = entity.Iade,
                AlinanUcret = fiyat


            });
            //araca durum ekle
            //Aracın durumunu değiştir aramada gözükmesin vs
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
            return new KiralikDTO
            {
                KiralikId = entity.KiralikId,
                KullaniciID = entity.KullaniciID,
                AracID = entity.AracID,
                Alis_Tarihi = entity.Alis_Tarihi,
                VerilisKm = entity.VerilisKm,
                Veris_Tarihi = entity.Veris_Tarihi,
                Iade = entity.Iade,
                AlinanUcret = entity.AlinanUcret
            };
        }
        [WebMethod]
        public List<KiralikDTO> GetAll()
        {
            return kiralikManager.GetAll().Select(entity => new KiralikDTO
            {
                KiralikId = entity.KiralikId,
                KullaniciID = entity.KullaniciID,
                AracID = entity.AracID,
                Alis_Tarihi = entity.Alis_Tarihi,
                VerilisKm = entity.VerilisKm,
                Veris_Tarihi = entity.Veris_Tarihi,
                Iade = entity.Iade,
                AlinanUcret = entity.AlinanUcret
            }).ToList();
        }
        [WebMethod]
        public void Update(KiralikDTO entity)
        {
            kiralikManager.Update(new Kiralik
            {
                KiralikId = entity.KiralikId,
                KullaniciID = entity.KullaniciID,
                AracID = entity.AracID,
                Alis_Tarihi = entity.Alis_Tarihi,
                VerilisKm = entity.VerilisKm,
                Veris_Tarihi = entity.Veris_Tarihi,
                Iade = entity.Iade,
                AlinanUcret = entity.AlinanUcret
            });
        }
    }
}
