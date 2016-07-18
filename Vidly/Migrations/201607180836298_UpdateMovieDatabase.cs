namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.s", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.s", "ReleaseDate", c => c.DateTime());
        }
    }
}
