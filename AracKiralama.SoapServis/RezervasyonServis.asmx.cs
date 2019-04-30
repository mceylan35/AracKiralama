using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.DTO.DTO;
using AracKiralama.Entities;
using AutoMapper;

namespace AracKiralama.SoapServis
{
    /// <summary>
    /// Summary description for RezervasyonServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RezervasyonServis : System.Web.Services.WebService
    {

        RezervasyonManager rezervasyonManager = new RezervasyonManager(new EfRezervasyonRepository());
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
            return Mapper.Map<RezervasyonDTO>(entity);
        }
        [WebMethod]
        public List<RezervasyonDTO> GetAll()
        {
            var rezervasyonlar = rezervasyonManager.GetAll();
            return Mapper.Map<List<RezervasyonDTO>>(rezervasyonlar).ToList();
        }
        [WebMethod]
        public void Update(RezervasyonDTO entity)
        {
            var rezervasyon = Mapper.Map<Rezervasyon>(entity);
            rezervasyonManager.Update(rezervasyon);
        }
    }
}
