using KafeYS.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace KafeYS
{
    public partial class KafeYS : DbContext
    {
        public KafeYS()
            : base("name=KafeYS")
        {
        }

        public DbSet<Kafe> Kafe { get; set; }

        public DbSet<Urun> Urunler { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Siparis> Siparisler { get; set; }

        public DbSet<Personel> Personeller {  get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kafe>().ToTable("Kafe");
            modelBuilder.Entity<Urun>().ToTable("Urun");
            modelBuilder.Entity<Kategori>().ToTable("Kategori");
            modelBuilder.Entity<Siparis>().ToTable("Siparis");
            modelBuilder.Entity<Personel>().ToTable("Personel");

            base.OnModelCreating(modelBuilder);
        }
    }
}
