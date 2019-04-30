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
    public class EfAracRepository:EfGenericRepository<Arac>,IAracRepository
    {
        public EfAracRepository()
        {
            context = new AracKiralamaContext();
        }

    }
}
