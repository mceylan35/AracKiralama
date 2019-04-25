using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Dal.Abstract;
using AracKiralama.DTO.DTO;
using AracKiralama.Entities;
using AracKiralama.Interfaces;


namespace AracKiralama.Bll
{
    public class KullaniciManager:GenericManager<Kullanici>,IKullaniciService
    {
        private IKullaniciRepository kullaniciRepository;

        public KullaniciManager(IKullaniciRepository _kullaniciRepository) : base(_kullaniciRepository)
        {
            kullaniciRepository = _kullaniciRepository;
        }
        //public IQueryable<Kullanici> GetAll()
        //{

        //    return genericRepository.GetAll().AsQueryable();

        //}

        public Kullanici KullaniciGiris(string eposta, string sifre)
        {
            try
            {
                if (string.IsNullOrEmpty(eposta.Trim()) || string.IsNullOrEmpty(sifre.Trim()))
                {
                    throw new Exception("Eposta ve şifre boş geçilemez");
                }
               var kullanici= kullaniciRepository.KullaniciGiris(eposta, sifre);
                if (kullanici==null)
                {
                    throw new Exception("Kullanıcı ve şifre uyuşmuyor.");
                }
                else
                {
                    return kullanici;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Kullanıcı Giriş hata" + e.Message);
            }

        }

       
    }
}
