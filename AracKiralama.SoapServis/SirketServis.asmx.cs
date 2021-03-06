﻿using System;
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
    /// Summary description for SirketServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SirketServis : System.Web.Services.WebService
    {
        private SirketManager sirketService = new SirketManager(new EfSirketRepository());

        [WebMethod]
        public SirketDTO Add(SirketDTO entity)
        {
            var sirket = Mapper.Map<Sirket>(entity);
            sirketService.Add(sirket);
            return entity;

        }

        [WebMethod]
        public bool Delete(int id)
        {

            return sirketService.Delete(id);

        }

        [WebMethod]
        public SirketDTO Get(int id)
        {
            var entity = sirketService.Get(id);
            return Mapper.Map<SirketDTO>(entity);
        }




        [WebMethod]
        public List<SirketDTO> GetAll()
        {

            var sirket = sirketService.GetAll();
            return Mapper.Map<List<SirketDTO>>(sirket).ToList();
        }




        [WebMethod]
        public void Update(int id)
        {
            var entity = sirketService.Get(id);
            var sirket = Mapper.Map<Sirket>(entity);
            sirketService.Update(sirket);

        }
    }
}
