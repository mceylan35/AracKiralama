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
         

    }
}
