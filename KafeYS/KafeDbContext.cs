using KafeYS.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace KafeYS
{
    public partial class KafeDbContext : DbContext
    {
        public KafeDbContext()
            : base("name=KafeYS")
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Kafe> Kafe { get; set; }

        public DbSet<Urun> Urunler { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Personel> Personeller { get; set; }

        public DbSet<Siparis> Siparisler { get; set; }

        public DbSet<SiparisDetay> SiparisDetaylari { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kafe>().ToTable("Kafe");
            modelBuilder.Entity<Urun>().ToTable("Urun");
            modelBuilder.Entity<Kategori>().ToTable("Kategori");
            modelBuilder.Entity<Siparis>().ToTable("Siparis");
            modelBuilder.Entity<SiparisDetay>().ToTable("SiparisDetay");
            modelBuilder.Entity<Personel>().ToTable("Personel");

            modelBuilder.Entity<SiparisDetay>()
            .HasRequired(sd => sd.Urun)
            .WithMany(u => u.SiparisDetaylari)
            .HasForeignKey(sd => sd.UrunId);

            modelBuilder.Entity<SiparisDetay>()
                .HasRequired(sd => sd.Siparis)
                .WithMany(s => s.SiparisDetaylari)
                .HasForeignKey(sd => sd.SiparisId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
