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
   public class SirketManager:GenericManager<Sirket>,ISirketService
   {
       private ISirketRepository sirketRepository;

       public SirketManager(ISirketRepository _sirketRepository) : base(_sirketRepository)
       {
           sirketRepository = _sirketRepository;
       }
       public short Test()
       {
           return 1;
       }
        ///deneme asdasda sad
       

       
    }
}
