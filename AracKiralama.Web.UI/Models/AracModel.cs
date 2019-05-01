﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AracKiralama.Web.UI.Models
{
    public class AracModel
    {
        public int AracId { get; set; }

        public string AracAdi { get; set; }

        public string Model { get; set; }

        public int? EhliyetYasi { get; set; }

        public int? MinYasSiniri { get; set; }

        public int? GunlukSinirKM { get; set; }

        public long? KendiAnlikKM { get; set; }

        public bool? AirBag { get; set; }

        public int? BagajHacmi { get; set; }

        public int? KoltukSayisi { get; set; }

        [Column(TypeName = "money")]
        public decimal? GunlukKiralikFiyat { get; set; }

        public int? SirketId { get; set; }

        public bool? Rezerve { get; set; }

        public string Resim { get; set; }
    }
}