namespace KafeYS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class masanoautoincrementoff : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Siparis", "Kafe_MasaNo", "dbo.Kafe");
            DropForeignKey("dbo.Siparis", "Kafe_MasaNo1", "dbo.Kafe");
            DropForeignKey("dbo.Siparis", "Kafe_MasaNo2", "dbo.Kafe");
            DropPrimaryKey("dbo.Kafe");
            AlterColumn("dbo.Kafe", "MasaNo", c => c.Int(nullable: false, identity: false));
            AddPrimaryKey("dbo.Kafe", "MasaNo");
            AddForeignKey("dbo.Siparis", "Kafe_MasaNo", "dbo.Kafe", "MasaNo");
            AddForeignKey("dbo.Siparis", "Kafe_MasaNo1", "dbo.Kafe", "MasaNo");
            AddForeignKey("dbo.Siparis", "Kafe_MasaNo2", "dbo.Kafe", "MasaNo");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Siparis", "Kafe_MasaNo2", "dbo.Kafe");
            DropForeignKey("dbo.Siparis", "Kafe_MasaNo1", "dbo.Kafe");
            DropForeignKey("dbo.Siparis", "Kafe_MasaNo", "dbo.Kafe");
            DropPrimaryKey("dbo.Kafe");
            AlterColumn("dbo.Kafe", "MasaNo", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Kafe", "MasaNo");
            AddForeignKey("dbo.Siparis", "Kafe_MasaNo2", "dbo.Kafe", "MasaNo");
            AddForeignKey("dbo.Siparis", "Kafe_MasaNo1", "dbo.Kafe", "MasaNo");
            AddForeignKey("dbo.Siparis", "Kafe_MasaNo", "dbo.Kafe", "MasaNo");
        }
    }
}
