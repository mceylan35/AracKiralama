using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.DTO.DTO
{
    public class MusteriDTO
    {
        public int MusteriId { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EhliyetAlimTarihi { get; set; }

        public string Email { get; set; }

        public string Sifre { get; set; }
    }
}
