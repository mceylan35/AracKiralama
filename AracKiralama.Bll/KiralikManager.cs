﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Dal.Abstract;
using AracKiralama.Entities;
using AracKiralama.Interfaces;

namespace AracKiralama.Bll
{
    public class KiralikManager:GenericManager<Kiralik>,IKiralikService
    {
        private IKiralikRepository kiralikRepository;
       
        public KiralikManager(IKiralikRepository _kiralikRepository) : base(_kiralikRepository)
        {
            kiralikRepository = _kiralikRepository;
            
        }

        

      
    }
}
