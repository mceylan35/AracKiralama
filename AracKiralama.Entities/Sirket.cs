namespace AracKiralama.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sirket")]
    public partial class Sirket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sirket()
        {
            Arac = new HashSet<Arac>();
        }

        public int SirketId { get; set; }

        public string SirketAdi { get; set; }

        public string Sehir { get; set; }

        public string Adres { get; set; }

        public string AracSayisi { get; set; }

        public int? SirketPuani { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arac> Arac { get; set; }
    }
}
