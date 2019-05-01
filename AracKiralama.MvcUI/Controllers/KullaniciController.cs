using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Context;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.MvcUI.KiralikServiceSoap;



namespace AracKiralama.MvcUI.Controllers
{
    public class KullaniciController : Controller
    {

   
        // GET: Kullanici
        public ActionResult Index()
        {
        
     
           
            return View();
        }
    }
}