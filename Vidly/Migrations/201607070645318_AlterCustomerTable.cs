using System.Data.Entity.Migrations.Model;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterCustomerTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DateOfBirth = '01-01-1980' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
