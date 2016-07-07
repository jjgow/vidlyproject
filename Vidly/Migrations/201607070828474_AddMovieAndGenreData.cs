using System.Diagnostics.Eventing.Reader;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieAndGenreData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Sci-Fi')");

            Sql("INSERT INTO Movies (Name, Genre_Id) VALUES ('Fight Club', 4)");
            Sql("INSERT INTO Movies (Name, Genre_Id) VALUES ('Interstellar', 5)");
            Sql("INSERT INTO Movies (Name, Genre_Id) VALUES ('The Matrix', 2)");
            Sql("INSERT INTO Movies (Name, Genre_Id) VALUES ('Ex Machina', 5)");
            Sql("INSERT INTO Movies (Name, Genre_Id) VALUES ('The Hustler', 3)");
        }
        
        public override void Down()
        {
        }
    }
}
