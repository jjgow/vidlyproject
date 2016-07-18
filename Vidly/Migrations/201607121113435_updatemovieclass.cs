namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemovieclass : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.s", name: "Genre_Id", newName: "GenreId");
            RenameIndex(table: "dbo.s", name: "IX_Genre_Id", newName: "IX_GenreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.s", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.s", name: "GenreId", newName: "Genre_Id");
        }
    }
}
