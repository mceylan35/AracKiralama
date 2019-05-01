using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AracKiralama.Web.UI.Models
{
    public class KullaniciModel
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

        public int? RoleId { get; set; }

        public int? SirketId { get; set; }

    }
}