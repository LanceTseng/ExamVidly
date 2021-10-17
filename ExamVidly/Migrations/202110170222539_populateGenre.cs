namespace ExamVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (id, name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (id, name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (id, name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (id, name) VALUES (4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
