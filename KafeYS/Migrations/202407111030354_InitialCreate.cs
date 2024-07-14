namespace KafeYS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kafe",
                c => new
                    {
                        MasaAdet = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MasaAdet);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        MasaNo = c.Int(nullable: false, identity: true),
                        Durum = c.Int(nullable: false),
                        OdenenTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SAcilisZamani = c.DateTime(nullable: false),
                        SKapanisZamani = c.DateTime(nullable: false),
                        SiparisId = c.Int(nullable: false),
                        PersonelId = c.Int(nullable: false),
                        SiparisDetay_SiparisId = c.Int(),
                        Kafe_MasaAdet = c.Int(),
                        Kafe_MasaAdet1 = c.Int(),
                    })
                .PrimaryKey(t => t.MasaNo)
                .ForeignKey("dbo.Personel", t => t.PersonelId, cascadeDelete: true)
                .ForeignKey("dbo.SiparisDetays", t => t.SiparisDetay_SiparisId)
                .ForeignKey("dbo.Kafe", t => t.Kafe_MasaAdet)
                .ForeignKey("dbo.Kafe", t => t.Kafe_MasaAdet1)
                .Index(t => t.PersonelId)
                .Index(t => t.SiparisDetay_SiparisId)
                .Index(t => t.Kafe_MasaAdet)
                .Index(t => t.Kafe_MasaAdet1);
            
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        PersonelId = c.Int(nullable: false, identity: true),
                        PersonelAd = c.String(nullable: false),
                        PersonelSoyad = c.String(nullable: false),
                        PersonelEmail = c.String(nullable: false),
                        PersonelTelNo = c.String(nullable: false),
                        PersonelİseGirisTarih = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        PersonelSifre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelId);
            
            CreateTable(
                "dbo.SiparisDetays",
                c => new
                    {
                        SiparisId = c.Int(nullable: false, identity: true),
                        UrunId = c.String(nullable: false),
                        UrunAdet = c.Int(nullable: false),
                        UrunFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Urun_UrunId = c.Int(),
                        Siparis_MasaNo = c.Int(),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Urun", t => t.Urun_UrunId)
                .ForeignKey("dbo.Siparis", t => t.Siparis_MasaNo)
                .Index(t => t.Urun_UrunId)
                .Index(t => t.Siparis_MasaNo);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(nullable: false),
                        BirimFiyat = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                        Kafe_MasaAdet = c.Int(),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategori", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Kafe", t => t.Kafe_MasaAdet)
                .Index(t => t.KategoriId)
                .Index(t => t.Kafe_MasaAdet);
            
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(nullable: false),
                        CategoryDesc = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urun", "Kafe_MasaAdet", "dbo.Kafe");
            DropForeignKey("dbo.Siparis", "Kafe_MasaAdet1", "dbo.Kafe");
            DropForeignKey("dbo.Siparis", "Kafe_MasaAdet", "dbo.Kafe");
            DropForeignKey("dbo.SiparisDetays", "Siparis_MasaNo", "dbo.Siparis");
            DropForeignKey("dbo.Siparis", "SiparisDetay_SiparisId", "dbo.SiparisDetays");
            DropForeignKey("dbo.SiparisDetays", "Urun_UrunId", "dbo.Urun");
            DropForeignKey("dbo.Urun", "KategoriId", "dbo.Kategori");
            DropForeignKey("dbo.Siparis", "PersonelId", "dbo.Personel");
            DropIndex("dbo.Urun", new[] { "Kafe_MasaAdet" });
            DropIndex("dbo.Urun", new[] { "KategoriId" });
            DropIndex("dbo.SiparisDetays", new[] { "Siparis_MasaNo" });
            DropIndex("dbo.SiparisDetays", new[] { "Urun_UrunId" });
            DropIndex("dbo.Siparis", new[] { "Kafe_MasaAdet1" });
            DropIndex("dbo.Siparis", new[] { "Kafe_MasaAdet" });
            DropIndex("dbo.Siparis", new[] { "SiparisDetay_SiparisId" });
            DropIndex("dbo.Siparis", new[] { "PersonelId" });
            DropTable("dbo.Kategori");
            DropTable("dbo.Urun");
            DropTable("dbo.SiparisDetays");
            DropTable("dbo.Personel");
            DropTable("dbo.Siparis");
            DropTable("dbo.Kafe");
        }
    }
}
