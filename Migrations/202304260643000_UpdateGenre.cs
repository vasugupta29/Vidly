namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Genres SET Name = 'Comedy' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
