using AracKiralama.Bll;
using AracKiralama.Entities;
using AracKiralama.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.DTO.DTO;
using AutoMapper;

namespace AracKiralama.SoapServis
{
    /// <summary>
    /// Summary description for RoleServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RoleServis : System.Web.Services.WebService
    {
        private RoleManager roleManager;

        public RoleServis()
        {
            roleManager=new RoleManager(new EfRoleRepository());
        }

        
        [WebMethod]
        public void Add(RoleDTO entity)
        {
            
            var role = Mapper.Map<Role>(entity);
            roleManager.Add(role);
        }

        [WebMethod]
        public bool Delete(int id)
        {
            return roleManager.Delete(id);
        }
      
        [WebMethod]
        public RoleDTO Get(int id)
        {
            return Mapper.Map<RoleDTO>(roleManager.Get(id));
        }
        [WebMethod]
        public List<RoleDTO> GetAll()
        {
             return Mapper.Map<List<RoleDTO>>(roleManager.GetAll());
            
        }


        [WebMethod]
        public RoleDTO Update(RoleDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
