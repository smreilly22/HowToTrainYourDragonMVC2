namespace HowToTrainYourDragon.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dragon", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dragon", "Image");
        }
    }
}
