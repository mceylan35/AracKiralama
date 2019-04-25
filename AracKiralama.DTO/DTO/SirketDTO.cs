using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AracKiralama.DTO.DTO
{
    public class SirketDTO
    {
        public int SirketId { get; set; }

        public string SirketAdi { get; set; }

        public string Sehir { get; set; }

        public string Adres { get; set; }

        public string AracSayisi { get; set; }

        public int? SirketPuani { get; set; }
    }
}