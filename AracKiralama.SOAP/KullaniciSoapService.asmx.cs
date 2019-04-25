using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Services;
using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.DTO.DTO;
using AracKiralama.Entities;
using AracKiralama.Interfaces;
using AutoMapper;

namespace AracKiralama.SOAP
{
    /// <summary>
    /// Summary description for KullaniciSoapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
   // [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KullaniciSoapService : System.Web.Services.WebService
    {
        private KullaniciManager kullaniciService = new KullaniciManager(new EfKullaniciRepository());
        
        [WebMethod]
        public void Add(KullaniciDTO entity)
        {
         kullaniciService.Add(new Kullanici
           {
               KullaniciId = entity.KullaniciId,
               Ad = entity.Ad,
               Soyad = entity.Soyad,
               DogumTarihi = entity.DogumTarihi,
               EhliyetAlimTarihi = entity.EhliyetAlimTarihi,
               RoleID = entity.RoleID,
               Email = entity.Email,
               Sifre = entity.Sifre
           });
          

        }
        [WebMethod]

        public bool Delete(int id)
        {
            return kullaniciService.Delete(id);
        }
        [WebMethod(MessageName = "EntitySil")]
        public bool Delete(KullaniciDTO entity)
        {
            return kullaniciService.Delete(new Kullanici
            {
                KullaniciId = entity.KullaniciId,
                Ad = entity.Ad,
                Soyad = entity.Soyad,
                DogumTarihi = entity.DogumTarihi,
                EhliyetAlimTarihi = entity.EhliyetAlimTarihi,
                RoleID = entity.RoleID,
                Email = entity.Email,
                Sifre = entity.Sifre
            });
        }


        [WebMethod]
        public KullaniciDTO Get(int id)
        {
            var entity= kullaniciService.Get(id);
            return  new KullaniciDTO
            {
                KullaniciId = entity.KullaniciId,
                Ad = entity.Ad,
                Soyad = entity.Soyad,
                DogumTarihi = entity.DogumTarihi,
                EhliyetAlimTarihi = entity.EhliyetAlimTarihi,
                RoleID = entity.RoleID,
                Email = entity.Email,
                Sifre = entity.Sifre
            };
        }
   
        [WebMethod]
        public List<KullaniciDTO> GetAll()
        {
           

            return kullaniciService.GetAll().Select(entity => new KullaniciDTO
            {
                KullaniciId = entity.KullaniciId,
                Ad = entity.Ad,
                Soyad = entity.Soyad,
                DogumTarihi = entity.DogumTarihi,
                EhliyetAlimTarihi = entity.EhliyetAlimTarihi,
                RoleID = entity.RoleID,
                Email = entity.Email,
                Sifre = entity.Sifre
            }).ToList();
        }



        [WebMethod]
        public KullaniciDTO KullaniciGiris(string eposta, string sifre)
        {
            var entity= kullaniciService.KullaniciGiris(eposta, sifre);
            return new KullaniciDTO
            {
                KullaniciId = entity.KullaniciId,
                Ad = entity.Ad,
                Soyad = entity.Soyad,
                DogumTarihi = entity.DogumTarihi,
                EhliyetAlimTarihi = entity.EhliyetAlimTarihi,
                RoleID = entity.RoleID,
                Email = entity.Email,
                Sifre = entity.Sifre
            };
        }





        [WebMethod]
        public void Update(KullaniciDTO entity)
        {
           // var k = kullaniciService.Get(entity.KullaniciId);
             kullaniciService.Update(new Kullanici
             {
                 KullaniciId = entity.KullaniciId,
                 Ad = entity.Ad,
                 Soyad = entity.Soyad,
                 DogumTarihi = entity.DogumTarihi,
                 EhliyetAlimTarihi = entity.EhliyetAlimTarihi,
                 RoleID = entity.RoleID,
                 Email = entity.Email,
                 Sifre = entity.Sifre


                 
             });
        }


    }
}
