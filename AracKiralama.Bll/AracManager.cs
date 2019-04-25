using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Dal.Abstract;
using AracKiralama.DTO.DTO;
using AracKiralama.Entities;
using AracKiralama.Interfaces;

namespace AracKiralama.Bll
{
    public class AracManager:GenericManager<Arac>,IAracService
    {
        private IAracRepository aracRepository;

        public AracManager(IAracRepository _aracRepository) : base(_aracRepository)
        {
            this.aracRepository = _aracRepository;
        }
    }
}
