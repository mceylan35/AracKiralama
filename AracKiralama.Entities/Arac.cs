namespace AracKiralama.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Arac")]
    public partial class Arac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arac()
        {
            Kiralik = new HashSet<Kiralik>();
            Rezervasyon = new HashSet<Rezervasyon>();
        }

        public int AracId { get; set; }

        public string AracAdi { get; set; }

        public string Model { get; set; }

        public string EhliyetYasi { get; set; }

        public byte? MinYasSiniri { get; set; }

        public int? GunlukSinirKM { get; set; }

        public long? KendiAnlikKM { get; set; }

        public bool? AirBag { get; set; }

        public int? BagajHacmi { get; set; }

        public byte? KoltukSayisi { get; set; }

        [Column(TypeName = "money")]
        public decimal? GunlukKiralikFiyat { get; set; }

        public int? SirketID { get; set; }

        public bool? Rezerve { get; set; }

        public string Resim { get; set; }

        public virtual Sirket Sirket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kiralik> Kiralik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervasyon> Rezervasyon { get; set; }
    }
}
