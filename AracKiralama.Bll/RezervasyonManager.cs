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
    public class RezervasyonManager:GenericManager<Rezervasyon>,IRezervasyonService
    {
        private IRezervasyonRepository rezervasyonRepository;

        public RezervasyonManager(IRezervasyonRepository _rezervasyonRepository) : base(_rezervasyonRepository)
        {
            rezervasyonRepository = _rezervasyonRepository;
        }
    }
}
