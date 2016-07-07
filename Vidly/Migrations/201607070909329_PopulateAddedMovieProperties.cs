namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAddedMovieProperties : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate = '11-11-1999', DateAdded = '07-07-2016', NumberInStock = 2 WHERE Id = 1");
            Sql("UPDATE Movies SET ReleaseDate = '11-06-2014', DateAdded = '07-07-2016', NumberInStock = 4 WHERE Id = 2");
            Sql("UPDATE Movies SET ReleaseDate = '04-08-2014', DateAdded = '07-07-2016', NumberInStock = 3 WHERE Id = 3");
            Sql("UPDATE Movies SET ReleaseDate = '03-05-2015', DateAdded = '07-07-2016', NumberInStock = 5 WHERE Id = 4");
            Sql("UPDATE Movies SET ReleaseDate = '09-25-1961', DateAdded = '07-07-2016', NumberInStock = 1 WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
