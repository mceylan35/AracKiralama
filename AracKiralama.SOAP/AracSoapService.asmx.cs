using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.DTO.DTO;
using AracKiralama.Entities;
using AracKiralama.Interfaces;

namespace AracKiralama.SOAP
{
    /// <summary>
    /// Summary description for AracSoapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AracSoapService : System.Web.Services.WebService
    {
        AracManager aracManager=new AracManager(new EfAracRepository());
        [WebMethod]
        public void Add(AracDTO entity)
        {
            aracManager.Add(new Arac
            {
                AracId = entity.AracId,
                AracAdi = entity.AracAdi,
                AirBag = entity.AirBag,
                BagajHacmi = entity.BagajHacmi,
                GunlukKiralikFiyat = entity.GunlukKiralikFiyat,
                GunlukSinirKM = entity.GunlukSinirKM,
                EhliyetYasi = entity.EhliyetYasi,
                KendiAnlikKM = entity.KendiAnlikKM,
                KoltukSayisi = entity.KoltukSayisi,
                MinYasSiniri = entity.MinYasSiniri,
                SirketID = entity.SirketID,
                Resim = entity.Resim,
                Rezerve = entity.Rezerve,
                Model = entity.Model

            });
        }
        [WebMethod]
        public bool Delete(int id)
        {
            return aracManager.Delete(id);
        }


        [WebMethod]
        public AracDTO Get(int id)
        {

            var entity = aracManager.Get(id);
            return new AracDTO
            {
                AracId = entity.AracId,
                AracAdi = entity.AracAdi,
                AirBag = entity.AirBag,
                BagajHacmi = entity.BagajHacmi,
                GunlukKiralikFiyat = entity.GunlukKiralikFiyat,
                GunlukSinirKM = entity.GunlukSinirKM,
                EhliyetYasi = entity.EhliyetYasi,
                KendiAnlikKM = entity.KendiAnlikKM,
                KoltukSayisi = entity.KoltukSayisi,
                MinYasSiniri = entity.MinYasSiniri,
                SirketID = entity.SirketID,
                Resim = entity.Resim,
                Rezerve = entity.Rezerve,
                Model = entity.Model
            };
        }
        [WebMethod]
        public List<AracDTO> GetAll()
        {
            return aracManager.GetAll().Select(entity=> new AracDTO
            {
                AracId = entity.AracId,
                AracAdi = entity.AracAdi,
                AirBag = entity.AirBag,
                BagajHacmi = entity.BagajHacmi,
                GunlukKiralikFiyat = entity.GunlukKiralikFiyat,
                GunlukSinirKM = entity.GunlukSinirKM,
                EhliyetYasi = entity.EhliyetYasi,
                KendiAnlikKM = entity.KendiAnlikKM,
                KoltukSayisi = entity.KoltukSayisi,
                MinYasSiniri = entity.MinYasSiniri,
                SirketID = entity.SirketID,
                Resim = entity.Resim,
                Rezerve = entity.Rezerve,
                Model = entity.Model
                
                
                

            }).ToList();
        }
        [WebMethod]
        public void Update(AracDTO entity)
        {
            aracManager.Update(new Arac
            {
                AracId = entity.AracId,
                AracAdi = entity.AracAdi,
                AirBag = entity.AirBag,
                BagajHacmi = entity.BagajHacmi,
                GunlukKiralikFiyat = entity.GunlukKiralikFiyat,
                GunlukSinirKM = entity.GunlukSinirKM,
                EhliyetYasi = entity.EhliyetYasi,
                KendiAnlikKM = entity.KendiAnlikKM,
                KoltukSayisi = entity.KoltukSayisi,
                MinYasSiniri = entity.MinYasSiniri,
                SirketID = entity.SirketID,
                Resim = entity.Resim,
                Rezerve = entity.Rezerve,
                Model = entity.Model
            });
        }
    }
}
