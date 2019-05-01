using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracKiralama.MvcUI.KiralikServiceSoap;

namespace AracKiralama.MvcUI.Controllers
{
    public class DefaultController : Controller
    {
        KiralikServiceSoapClient k = new KiralikServiceSoapClient();

        // GET: Default
        public ActionResult Index()
        {
            k.Add(new KiralikDTO
            {
                AracID = 1,
                AlinanUcret = 5,
                Alis_Tarihi = DateTime.Now,
                VerilisKm = 500,
                Iade = true,
                KullaniciID = 1,

            });
            return View();
        }
    }
}