using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Dal.Abstract;
using AracKiralama.Dal.Concrete.EntityFramework.Context;
using AracKiralama.DTO.DTO;
using AracKiralama.Entities;

namespace AracKiralama.Dal.Concrete.EntityFramework.Repository
{
   public class EfKullaniciRepository:EfGenericRepository<Kullanici>,IKullaniciRepository
    {
        public EfKullaniciRepository()
        {
            context=new AracKiralamaContext();
        }

        public Kullanici KullaniciGiris(string eposta, string sifre)
        {
            return context.Kullanici.FirstOrDefault(x=>x.Email==eposta && x.Sifre==sifre);
        }

      
    }
}
