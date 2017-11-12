namespace HireMeFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserProfileUpdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "firstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "lastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address1", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address2", c => c.String());
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "State", c => c.String());
            AddColumn("dbo.AspNetUsers", "zipCode", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "HomePhone", c => c.String());
            AddColumn("dbo.AspNetUsers", "cellPhone", c => c.String());
            AddColumn("dbo.AspNetUsers", "Major", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Major");
            DropColumn("dbo.AspNetUsers", "cellPhone");
            DropColumn("dbo.AspNetUsers", "HomePhone");
            DropColumn("dbo.AspNetUsers", "zipCode");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "Address2");
            DropColumn("dbo.AspNetUsers", "Address1");
            DropColumn("dbo.AspNetUsers", "lastName");
            DropColumn("dbo.AspNetUsers", "firstName");
        }
    }
}
