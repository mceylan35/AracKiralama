using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Dal.Abstract;
using AracKiralama.Dal.Concrete.EntityFramework.Context;
using AracKiralama.Entities;

namespace AracKiralama.Dal.Concrete.EntityFramework.Repository
{
    public class EfMusteriRepository : EfGenericRepository<Musteri>, IMusteriRepository
    {
        public EfMusteriRepository()
        {
            context = new AracKiralamaContext();
        }

        public Musteri MusteriGiris(string eposta, string sifre)
        {
            return context.Musteri.FirstOrDefault(x => x.Email == eposta && x.Sifre == sifre);
        }
    }
}
