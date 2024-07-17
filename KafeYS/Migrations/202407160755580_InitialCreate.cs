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
                        MasaNo = c.Int(nullable: false, identity: true),
                        MasaAdet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MasaNo);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        SiparisId = c.Int(nullable: false, identity: true),
                        MasaNo = c.Int(nullable: false),
                        Durum = c.Int(nullable: false),
                        OdenenTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SAcilisZamani = c.DateTime(nullable: false),
                        SKapanisZamani = c.DateTime(nullable: false),
                        PersonelId = c.Int(nullable: false),
                        Kafe_MasaNo = c.Int(),
                        Kafe_MasaNo1 = c.Int(),
                        Kafe_MasaNo2 = c.Int(),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Kafe", t => t.Kafe_MasaNo)
                .ForeignKey("dbo.Personel", t => t.PersonelId, cascadeDelete: true)
                .ForeignKey("dbo.Kafe", t => t.Kafe_MasaNo1)
                .ForeignKey("dbo.Kafe", t => t.Kafe_MasaNo2)
                .Index(t => t.PersonelId)
                .Index(t => t.Kafe_MasaNo)
                .Index(t => t.Kafe_MasaNo1)
                .Index(t => t.Kafe_MasaNo2);
            
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
                        AccesLevel = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelId);
            
            CreateTable(
                "dbo.SiparisDetays",
                c => new
                    {
                        SiparisDetayId = c.Int(nullable: false, identity: true),
                        UrunId = c.String(nullable: false),
                        UrunAdet = c.Int(nullable: false),
                        UrunFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Urun_UrunId = c.Int(),
                        Siparis_SiparisId = c.Int(),
                    })
                .PrimaryKey(t => t.SiparisDetayId)
                .ForeignKey("dbo.Urun", t => t.Urun_UrunId)
                .ForeignKey("dbo.Siparis", t => t.Siparis_SiparisId)
                .Index(t => t.Urun_UrunId)
                .Index(t => t.Siparis_SiparisId);
            
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
            DropForeignKey("dbo.Siparis", "Kafe_MasaNo2", "dbo.Kafe");
            DropForeignKey("dbo.Siparis", "Kafe_MasaNo1", "dbo.Kafe");
            DropForeignKey("dbo.SiparisDetays", "Siparis_SiparisId", "dbo.Siparis");
            DropForeignKey("dbo.SiparisDetays", "Urun_UrunId", "dbo.Urun");
            DropForeignKey("dbo.Urun", "KategoriId", "dbo.Kategori");
            DropForeignKey("dbo.Siparis", "PersonelId", "dbo.Personel");
            DropForeignKey("dbo.Siparis", "Kafe_MasaNo", "dbo.Kafe");
            DropIndex("dbo.Urun", new[] { "KategoriId" });
            DropIndex("dbo.SiparisDetays", new[] { "Siparis_SiparisId" });
            DropIndex("dbo.SiparisDetays", new[] { "Urun_UrunId" });
            DropIndex("dbo.Siparis", new[] { "Kafe_MasaNo2" });
            DropIndex("dbo.Siparis", new[] { "Kafe_MasaNo1" });
            DropIndex("dbo.Siparis", new[] { "Kafe_MasaNo" });
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
