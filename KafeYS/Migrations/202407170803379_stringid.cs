namespace KafeYS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SiparisDetays", "Urun_UrunId", "dbo.Urun");
            DropIndex("dbo.SiparisDetays", new[] { "Urun_UrunId" });
            DropColumn("dbo.SiparisDetays", "UrunId");
            RenameColumn(table: "dbo.SiparisDetays", name: "Urun_UrunId", newName: "UrunId");
            AlterColumn("dbo.SiparisDetays", "UrunId", c => c.Int(nullable: false));
            AlterColumn("dbo.SiparisDetays", "UrunId", c => c.Int(nullable: false));
            CreateIndex("dbo.SiparisDetays", "UrunId");
            AddForeignKey("dbo.SiparisDetays", "UrunId", "dbo.Urun", "UrunId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetays", "UrunId", "dbo.Urun");
            DropIndex("dbo.SiparisDetays", new[] { "UrunId" });
            AlterColumn("dbo.SiparisDetays", "UrunId", c => c.Int());
            AlterColumn("dbo.SiparisDetays", "UrunId", c => c.String(nullable: false));
            RenameColumn(table: "dbo.SiparisDetays", name: "UrunId", newName: "Urun_UrunId");
            AddColumn("dbo.SiparisDetays", "UrunId", c => c.String(nullable: false));
            CreateIndex("dbo.SiparisDetays", "Urun_UrunId");
            AddForeignKey("dbo.SiparisDetays", "Urun_UrunId", "dbo.Urun", "UrunId");
        }
    }
}
