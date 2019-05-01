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
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {

            CreateMap<AracDTO, Arac>();
            CreateMap<Arac, AracDTO>();
            //CreateMap<AracDTO, Arac>()
            //    .ForMember(x => x.Sirket, opt => opt.Ignore())
            //    .ForMember(x => x.Kiralik, opt => opt.Ignore()).IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
               
            CreateMap<Sirket, SirketDTO>(MemberList.None);
            CreateMap<SirketDTO, Sirket>(MemberList.None);
            CreateMap<Kiralik, KiralikDTO>(MemberList.None);
            CreateMap<Musteri, MusteriDTO>(MemberList.None);
            CreateMap<Kullanici, KullaniciDTO>(MemberList.None);




        }
    }
}
