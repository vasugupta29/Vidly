namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Name = c.String(),
                        Tagline = c.String(),
                        Schedule = c.DateTime(nullable: false),
                        Description = c.String(),
                        Image = c.Binary(),
                        Moderator = c.String(),
                        Category = c.String(),
                        Sub_Category = c.String(),
                        Rigor_Rank = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
