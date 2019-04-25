using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.DTO.DTO
{
    public class RezervasyonDTO
    {
        public int RezerveId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RezerveTarih { get; set; }

        public bool? Rezerved { get; set; }

        public int? KullaniciId { get; set; }

        public int? AracId { get; set; }
    }
}
