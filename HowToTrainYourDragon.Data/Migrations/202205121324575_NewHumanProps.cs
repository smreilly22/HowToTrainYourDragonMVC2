namespace HowToTrainYourDragon.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewHumanProps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Human", "Gender", c => c.String());
            AddColumn("dbo.Human", "HairColor", c => c.String(nullable: false));
            AddColumn("dbo.Human", "Eyecolor", c => c.String(nullable: false));
            AddColumn("dbo.Human", "HasDragon", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Human", "HasDragon");
            DropColumn("dbo.Human", "Eyecolor");
            DropColumn("dbo.Human", "HairColor");
            DropColumn("dbo.Human", "Gender");
        }
    }
}
