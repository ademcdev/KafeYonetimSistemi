namespace KafeYS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class urunad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SiparisDetay", "UrunAd", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SiparisDetay", "UrunAd");
        }
    }
}
