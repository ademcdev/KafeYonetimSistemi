namespace KafeYS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Siparis", "MasaNo", "dbo.Kafe");
            DropIndex("dbo.Siparis", new[] { "MasaNo" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Siparis", "MasaNo");
            AddForeignKey("dbo.Siparis", "MasaNo", "dbo.Kafe", "MasaNo", cascadeDelete: true);
        }
    }
}
