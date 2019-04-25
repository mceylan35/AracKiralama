using AracKiralama.Bll;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AracKiralama.MvcUI.Controllers
{
    public class DefaultController : Controller
    {
        private IKullaniciService kullaniciService = new KullaniciManager(new EfKullaniciRepository());
        // GET: Default
        public ActionResult Index()
        {
           var a= kullaniciService.GetAll();
            return View();
        }
    }
}