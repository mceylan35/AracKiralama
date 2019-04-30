using AracKiralama.DTO.DTO;
using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace AracKiralama.Helpers.Mapping
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Arac, AracDTO>();
            CreateMap<Kiralik, KiralikDTO>();
            CreateMap<Sirket, SirketDTO>();
            CreateMap<Kullanici, KullaniciDTO>();
            CreateMap<Rezervasyon, RezervasyonDTO>();

        }
    }
}
