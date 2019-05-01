namespace AracKiralama.Dal.Concrete.EntityFramework.Context
{
    using AracKiralama.Entities;
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AracKiralamaContext : DbContext
    {
        public AracKiralamaContext()
            : base("name=AracKiralamaContext")
        {
        }

        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<Kiralik> Kiralik { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Sirket> Sirket { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arac>()
                .Property(e => e.GunlukKiralikFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Kiralik>()
                .Property(e => e.AlinanUcret)
                .HasPrecision(19, 4);
        }

    }
}
