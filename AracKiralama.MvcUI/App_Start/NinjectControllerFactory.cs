using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracKiralama.Interfaces;
using Ninject;

namespace AracKiralama.MvcUI.App_Start
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private readonly IKernel kernel;
        public NinjectControllerFactory()
        {
            kernel=new StandardKernel();
            AddBllBinds();
        }

        private void AddBllBinds()
        {
           
        }
    }
}