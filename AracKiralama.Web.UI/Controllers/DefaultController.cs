using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracKiralama.Web.UI.AracServis;
using AracKiralama.Web.UI.Models;
using AutoMapper;

namespace AracKiralama.Web.UI.Controllers
{
    public class DefaultController : Controller
    {
        AracServisSoapClient aracServis=new AracServisSoapClient();
        // GET: Default
        public ActionResult Index()
        {
           var araclar=Mapper.Map<List<AracModel>>(aracServis.GetAll());
            return View(araclar);
        }
    }
}