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
    /// Summary description for KullaniciServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KullaniciServis : System.Web.Services.WebService
    {

        private KullaniciManager kullaniciService = new KullaniciManager(new EfKullaniciRepository());

        [WebMethod]
        public void Add(KullaniciDTO entity)
        {
            var kullanici = Mapper.Map<Kullanici>(entity);
            kullaniciService.Add(kullanici);


        }
        [WebMethod]

        public bool Delete(int id)
        {
            return kullaniciService.Delete(id);
        }
     


        [WebMethod]
        public KullaniciDTO Get(int id)
        {
            var entity = kullaniciService.Get(id);
            return Mapper.Map<KullaniciDTO>(entity);
        }

        [WebMethod]
        public List<KullaniciDTO> GetAll()
        {
            var kullanicilar = kullaniciService.GetAll();

            return Mapper.Map<List<KullaniciDTO>>(kullanicilar).ToList();
        }



        [WebMethod]
        public KullaniciDTO KullaniciGiris(string eposta, string sifre)
        {
            var entity = kullaniciService.KullaniciGiris(eposta, sifre);
            return Mapper.Map<KullaniciDTO>(entity);
        }





        [WebMethod]
        public void Update(KullaniciDTO entity)
        {
         
            var kullanici = Mapper.Map<Kullanici>(entity);
            kullaniciService.Update(kullanici);
        }
    }
}
