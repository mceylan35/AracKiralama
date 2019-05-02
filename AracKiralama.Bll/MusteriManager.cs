using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Dal.Abstract;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.Entities;
using AracKiralama.Interfaces;

namespace AracKiralama.Bll
{
    public class MusteriManager:GenericManager<Musteri>, IMusteriService
    {
        private IMusteriRepository musteriRepository;

        public MusteriManager(IMusteriRepository _musteriRepository) : base(_musteriRepository)
        {
            musteriRepository = _musteriRepository;
        }
      

        public Musteri MusteriGiris(string eposta, string sifre)
        {
            try
            {
                if (string.IsNullOrEmpty(eposta.Trim()) || string.IsNullOrEmpty(sifre.Trim()))
                {
                    throw new Exception("Eposta ve şifre boş geçilemez");
                }
                var musteri = musteriRepository.MusteriGiris(eposta, sifre);
                if (musteri == null)
                {
                    throw new Exception("Kullanıcı ve şifre uyuşmuyor.");
                }
                else
                {
                    return musteri;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Kullanıcı Giriş hata" + e.Message);
            }
        }
    }
}
