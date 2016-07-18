namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.s", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.s", "DateAdded", c => c.DateTime());
            AddColumn("dbo.s", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.s", "NumberInStock");
            DropColumn("dbo.s", "DateAdded");
            DropColumn("dbo.s", "ReleaseDate");
        }
    }
}
