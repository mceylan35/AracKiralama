using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AracKiralama.DTO.DTO
{
    public class KullaniciDTO
    {
        public int KullaniciId { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EhliyetAlimTarihi { get; set; }

        [StringLength(50)]
        public string Sifre { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }

        public int? RoleID { get; set; }
    }
}