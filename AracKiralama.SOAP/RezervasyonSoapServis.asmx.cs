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
    /// Summary description for RezervasyonSoapServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RezervasyonSoapServis : System.Web.Services.WebService
    {
        RezervasyonManager rezervasyonManager=new RezervasyonManager(new EfRezervasyonRepository());
        private AracManager aracManager = new AracManager(new EfAracRepository());
        [WebMethod]
        public void Add(RezervasyonDTO entity)
        {

            rezervasyonManager.Add(new Rezervasyon
            {
                AracId = entity.AracId,
                KullaniciId = entity.KullaniciId,
                Rezerved = true,
                RezerveId = entity.RezerveId,
                RezerveTarih = entity.RezerveTarih
                //2 tarih arası rezerve edilecek 
                //araca durum ekle
                //Aracın durumunu değiştir aramada gözükmesin vs
                
            });
        }
        [WebMethod]
        public bool Delete(int id)
        {
            return rezervasyonManager.Delete(id);
        }


        [WebMethod]
        public RezervasyonDTO Get(int id)
        {
            var entity = rezervasyonManager.Get(id);
            return new RezervasyonDTO
            {
                AracId = entity.AracId,
                KullaniciId = entity.KullaniciId,
                Rezerved = entity.Rezerved,
                RezerveId = entity.RezerveId,
                RezerveTarih = entity.RezerveTarih
            };
        }
        [WebMethod]
        public List<RezervasyonDTO> GetAll()
        {
            return rezervasyonManager.GetAll().Select(entity => new RezervasyonDTO
            {
                AracId = entity.AracId,
                KullaniciId = entity.KullaniciId,
                Rezerved = entity.Rezerved,
                RezerveId = entity.RezerveId,
                RezerveTarih = entity.RezerveTarih

            }).ToList();
        }
        [WebMethod]
        public void Update(RezervasyonDTO entity)
        {
            rezervasyonManager.Update(new Rezervasyon
            {
                AracId = entity.AracId,
                KullaniciId = entity.KullaniciId,
                Rezerved = entity.Rezerved,
                RezerveId = entity.RezerveId,
                RezerveTarih = entity.RezerveTarih
            });
        }
    }
}
