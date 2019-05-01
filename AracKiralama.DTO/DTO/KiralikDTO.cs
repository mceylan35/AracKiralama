﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.DTO.DTO
{
    public class KiralikDTO
    {
        public int KiralikId { get; set; }

        public int? AracId { get; set; }

        public DateTime? Alis_Tarihi { get; set; }

        public DateTime? Veris_Tarihi { get; set; }

        public long? VerilisKm { get; set; }

        [Column(TypeName = "money")]
        public decimal? AlinanUcret { get; set; }

        public bool? Iade { get; set; }

        public bool? Durum { get; set; }

        public int? MusteriId { get; set; }



    }
}
