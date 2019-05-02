using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.DTO.DTO;
using AracKiralama.Entities;
using AutoMapper;

namespace AracKiralama.SoapServis
{
    /// <summary>
    /// Summary description for MusteriServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MusteriServis : System.Web.Services.WebService
    {
        MusteriManager musteriManager = new MusteriManager(new EfMusteriRepository());
        // private AracManager aracManager = new AracManager(new EfAracRepository());
        [WebMethod]
        public void Add(MusteriDTO entity)
        {


        }
        [WebMethod]
        public bool Delete(int id)
        {
            return musteriManager.Delete(id);
        }


        [WebMethod]
        public MusteriDTO Get(int id)
        {
            var entity = musteriManager.Get(id);
            return Mapper.Map<MusteriDTO>(entity);
        }
        [WebMethod]
        public List<MusteriDTO> GetAll()
        {
            var musteriler = musteriManager.GetAll();
            return Mapper.Map<List<MusteriDTO>>(musteriler).ToList();
        }
        [WebMethod]
        public void Update(MusteriDTO entity)
        {
            var musteri = Mapper.Map<Musteri>(entity);
            musteriManager.Update(musteri);
        }
    }
}
