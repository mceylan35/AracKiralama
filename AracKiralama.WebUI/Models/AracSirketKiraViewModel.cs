using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AracKiralama.Entities;

namespace AracKiralama.WebUI.Models
{
    public class AracSirketKiraViewModel
    {
        public List<Sirket> Sirketler { get; set; }
        public List<Arac> Araclar { get; set; }
        public List<Kiralik> Kiraliklar { get; set; }
    }
}