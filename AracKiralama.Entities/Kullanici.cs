namespace AracKiralama.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            Kiralik = new HashSet<Kiralik>();
            Rezervasyon = new HashSet<Rezervasyon>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kiralik> Kiralik { get; set; }

        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervasyon> Rezervasyon { get; set; }
    }
}
