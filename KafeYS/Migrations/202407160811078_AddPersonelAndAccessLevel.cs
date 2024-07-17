namespace KafeYS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonelAndAccessLevel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personel", "AccessLevel", c => c.Int(nullable: false));
            DropColumn("dbo.Personel", "AccesLevel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personel", "AccesLevel", c => c.String(nullable: false));
            DropColumn("dbo.Personel", "AccessLevel");
        }
    }
}
