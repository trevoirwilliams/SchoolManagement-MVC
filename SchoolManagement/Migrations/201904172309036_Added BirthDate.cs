namespace SchoolManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BirthDate");
        }
    }
}
