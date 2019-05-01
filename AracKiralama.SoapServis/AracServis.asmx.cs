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
    /// Summary description for AracServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AracServis : System.Web.Services.WebService
    {

        private AracManager aracManager;


        public AracServis()
        {
            aracManager = new AracManager(new EfAracRepository());
        }
        [WebMethod]
        public bool Add(AracDTO entity)
        {
            try
            {
                var arac = Mapper.Map<Arac>(entity);


                aracManager.Add(arac);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        [WebMethod]
        public bool Delete(int id)
        {
            try
            {
                aracManager.Delete(id);
                return true;
            }
            catch 
            {
                return false;
            }

        }




        [WebMethod]
        public AracDTO Get(int id)
        {

            var entity = aracManager.Get(id);


            return Mapper.Map<Arac, AracDTO>(entity);


        }
        [WebMethod]
        public List<AracDTO> GetAll()
        {
            var araclar = aracManager.GetAll();

            return Mapper.Map<List<AracDTO>>(araclar);

        }

        [WebMethod]
        public bool Update(AracDTO entity)
        {
            try
            {
                var arac = Mapper.Map<Arac>(entity);

                aracManager.Update(arac);
                return true;
            }
            catch 
            {
                return false;
            }

        }
    }
}
