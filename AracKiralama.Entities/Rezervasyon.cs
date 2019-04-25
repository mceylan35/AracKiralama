namespace AracKiralama.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rezervasyon")]
    public partial class Rezervasyon
    {
        [Key]
        public int RezerveId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RezerveTarih { get; set; }

        public bool? Rezerved { get; set; }

        public int? KullaniciId { get; set; }

        public int? AracId { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
