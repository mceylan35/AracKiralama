using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;
using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.DTO.DTO;
using AracKiralama.Entities;
using AracKiralama.Interfaces;


namespace AracKiralama.SOAP
{
    /// <summary>
    /// Summary description for SirketSoapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
  //  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SirketSoapService : System.Web.Services.WebService
    {
        private SirketManager sirketService = new SirketManager(new EfSirketRepository());

        [WebMethod]
        public SirketDTO Add(SirketDTO entity)
        {
           sirketService.Add(new Sirket
            {
                SirketAdi = entity.SirketAdi,
                Adres = entity.Adres,
                AracSayisi = entity.AracSayisi,
                Sehir = entity.Sehir,
                SirketPuani = entity.SirketPuani,
                SirketId = entity.SirketId

            });
            return entity;

        }

        [WebMethod]
        public bool Delete(int id)
        {
            var entity = sirketService.Get(id);
            return sirketService.Delete(new Sirket
            {
                SirketAdi = entity.SirketAdi,
                Adres = entity.Adres,
                AracSayisi = entity.AracSayisi,
                Sehir = entity.Sehir,
                SirketPuani = entity.SirketPuani,
                SirketId = entity.SirketId
            });
        }
        [WebMethod(MessageName = "EntitySil")]
        public bool Delete(SirketDTO entity)
        {
            return sirketService.Delete(new Sirket
            {
                SirketAdi = entity.SirketAdi,
                Adres = entity.Adres,
                AracSayisi = entity.AracSayisi,
                Sehir = entity.Sehir,
                SirketPuani = entity.SirketPuani,
                SirketId = entity.SirketId
            });
        }
        [WebMethod]
        public SirketDTO Get(int id)
        {
            var entity = sirketService.Get(id);
            return new SirketDTO
            {
                SirketAdi = entity.SirketAdi,
                Adres = entity.Adres,
                AracSayisi = entity.AracSayisi,
                Sehir = entity.Sehir,
                SirketPuani = entity.SirketPuani,
                SirketId = entity.SirketId
            };
        }




        [WebMethod]
        public List<SirketDTO> GetAll()
        {

            var sirket = sirketService.GetAll().Select(entity => new SirketDTO
            {
                SirketAdi = entity.SirketAdi,
                Adres = entity.Adres,
                AracSayisi = entity.AracSayisi,
                Sehir = entity.Sehir,
                SirketPuani = entity.SirketPuani,
                SirketId = entity.SirketId
            }).ToList();
            return sirket;
        }

       

      
        [WebMethod]
        public void Update(int id)
        {
            var entity = sirketService.Get(id);
            sirketService.Update(new Sirket
            {
                SirketAdi = entity.SirketAdi,
                Adres = entity.Adres,
                AracSayisi = entity.AracSayisi,
                Sehir = entity.Sehir,
                SirketPuani = entity.SirketPuani,
                SirketId = entity.SirketId
            });

        }

    }
   

}
