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
                        MasaNo = c.Int(nullable: false),
                        MasaAdet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MasaNo);
            
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
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(nullable: false),
                        BirimFiyat = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategori", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.SiparisDetay",
                c => new
                    {
                        SiparisDetayId = c.Int(nullable: false, identity: true),
                        SiparisId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        UrunAdet = c.Int(nullable: false),
                        UrunFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SiparisDetayId)
                .ForeignKey("dbo.Siparis", t => t.SiparisId, cascadeDelete: true)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.SiparisId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        SiparisId = c.Int(nullable: false, identity: true),
                        MasaNo = c.Int(nullable: false),
                        Durum = c.Int(nullable: false),
                        OdenenTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SAcilisZamani = c.DateTime(nullable: false),
                        SKapanisZamani = c.DateTime(),
                        PersonelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Kafe", t => t.MasaNo, cascadeDelete: true)
                .ForeignKey("dbo.Personel", t => t.PersonelId, cascadeDelete: true)
                .Index(t => t.MasaNo)
                .Index(t => t.PersonelId);
            
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
                        AccessLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetay", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.SiparisDetay", "SiparisId", "dbo.Siparis");
            DropForeignKey("dbo.Siparis", "PersonelId", "dbo.Personel");
            DropForeignKey("dbo.Siparis", "MasaNo", "dbo.Kafe");
            DropForeignKey("dbo.Urun", "KategoriId", "dbo.Kategori");
            DropIndex("dbo.Siparis", new[] { "PersonelId" });
            DropIndex("dbo.Siparis", new[] { "MasaNo" });
            DropIndex("dbo.SiparisDetay", new[] { "UrunId" });
            DropIndex("dbo.SiparisDetay", new[] { "SiparisId" });
            DropIndex("dbo.Urun", new[] { "KategoriId" });
            DropTable("dbo.Personel");
            DropTable("dbo.Siparis");
            DropTable("dbo.SiparisDetay");
            DropTable("dbo.Urun");
            DropTable("dbo.Kategori");
            DropTable("dbo.Kafe");
        }
    }
}
